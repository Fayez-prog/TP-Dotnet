using Gestion_Ventes.Helpers;
using Gestion_Ventes.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Gestion_Ventes.Controllers
{
    public class ChatLigneOrdersController : Controller
    {
        private readonly ChatService _chatService;
        private readonly HttpClient _httpClient;

        public ChatLigneOrdersController(IConfiguration configuration, HttpClient httpClient)
        {
            _chatService = new ChatService(configuration);
            _httpClient = httpClient;
        }

        [Route("chat/LigneOrders")]
        [HttpGet]
        public IActionResult Chat()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Questionner(string UserQuestion)
        {
            if (string.IsNullOrEmpty(UserQuestion))
            {
                ViewData["ResponseMessage"] = "La question est requise.";
                return View("Chat");
            }

            var analysis = await AnalyzeIntent(UserQuestion);
            var data = await _chatService.ExecuteSqlQuery(analysis);
            ViewData["ResponseMessage"] = GenerateResponse(data);

            return View("Chat");
        }

        private async Task<string> AnalyzeIntent(string userQuestion)
        {
            var prompt = $@"
                Tu es un assistant spécialisé en bases de données SQL Server.
                Génère une requête SQL Server valide et optimisée pour répondre à la question suivante :
                '{userQuestion}'
                - Assure-toi que la syntaxe est correcte et compatible avec SQL Server.
                - Si la question manque de précision, propose une requête qui retourne toutes les lignes de la table LigneOrders.
                - Utilise des alias explicites pour améliorer la lisibilité si nécessaire.
                - Le nom de la table est LigneOrders.
                - Évite les requêtes dangereuses comme la suppression ou la modification massive des données.
                - Les champs sont : LigneOrderID, OrderQty, LineltemTotal, OrderID, ProductID.
                - Le champ OrderID est une clé étrangère qui fait référence à OrderID de la table Orders.
                - Le champ ProductID est une clé étrangère qui fait référence à ProductID de la table Products.
                - Le champ CustomerID dans orders est une clé étrangère qui fait référence à customers et qui sert à retrouver LastName et EmailAddress.
                - Retourne uniquement la requête SQL, sans explication supplémentaire ni commentaire.
                - La requête se termine toujours par un point-virgule.
            ";

            var llamaResponse = await CallLlama(prompt);
            var responseText = "";

            try
            {
                dynamic responseObject = JsonConvert.DeserializeObject(llamaResponse);
                responseText = responseObject.response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'analyse de la réponse : {ex.Message}");
            }

            return responseText;
        }

        private async Task<string> CallLlama(string prompt)
        {
            var requestContent = new OllamaRequest
            {
                Model = "llama3",
                Prompt = prompt,
                Stream = false
            };

            var jsonRequest = System.Text.Json.JsonSerializer.Serialize(requestContent);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("http://localhost:11434/api/generate", content);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            return "Error contacting Ollama API";
        }

        private string GenerateResponse(List<Dictionary<string, object>> data)
        {
            if (data.Count == 0)
                return "Aucune donnée trouvée.";

            var response = "<ul>";
            foreach (var row in data)
            {
                response += "<li>" + string.Join(", ", row.Select(kv => $"{kv.Key}: {kv.Value}")) + "</li>";
            }
            response += "</ul>";
            return response;
        }
    }
}
