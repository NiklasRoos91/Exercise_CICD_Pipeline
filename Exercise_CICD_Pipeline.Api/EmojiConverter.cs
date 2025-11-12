namespace Exercise_CICD_Pipeline.Api
{
    public class EmojiConverter
    {
        public string ToEmoji(string word)
        {
            return word.ToLower() switch
            {
                "happy" => "😊",
                "sad" => "😢",
                "fire" => "🔥",
                "love" => "❤️",
                "star" => "⭐",
                "dog" => "🐶",
                "cat" => "🐱",
                "cow" => "🐄",
                "sun" => "☀️",
                "moon" => "🌙",
                "rain" => "🌧️",
                "snow" => "❄️",
                "coffee" => "☕",
                "music" => "🎵",
                "party" => "🎉",
                "pizza" => "🍕",
                "cake" => "🎂",
                "money" => "💰",
                "thumbsup" => "👍",
                _ => "❓"
            };
        }
    }
}
