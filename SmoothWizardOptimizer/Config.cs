using System.Text.Json.Serialization;
using CounterStrikeSharp.API.Core;

namespace SmoothWizardOptimizer
{
    /// <summary>configs/plugins/SmoothWizardOptimizer/SmoothWizardOptimizer.json, written on first load.</summary>
    public class OptimizerConfig : BasePluginConfig
    {
        /// <summary>
        /// Chat line to everyone after the round-start cleanup ("Removed N map junk/effects").
        /// false = cleanup still runs and is still logged to the server console, just not in chat.
        /// </summary>
        [JsonPropertyName("ShowCleanupChatMessage")]
        public bool ShowCleanupChatMessage { get; set; } = true;

        /// <summary>
        /// Permission a player needs for the css_sw_* commands. The server console and RCON always
        /// have access. Empty = every player (the old behaviour).
        /// </summary>
        [JsonPropertyName("AdminPermission")]
        public string AdminPermission { get; set; } = "@css/root";
    }
}
