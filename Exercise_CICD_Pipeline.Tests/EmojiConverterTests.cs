using Exercise_CICD_Pipeline.Api;

namespace Exercise_CICD_Pipeline.Tests
{
    public class EmojiConverterTests
    {
        private EmojiConverter _converter;

        [SetUp]
        public void Setup()
        {
            _converter = new EmojiConverter();
        }

        [Test]
        public void ToEmoji_ReturnsCorrectEmoji_ForKnownWords()
        {
            Assert.AreEqual("😊", _converter.ToEmoji("happy"));
            Assert.AreEqual("😢", _converter.ToEmoji("sad"));
            Assert.AreEqual("🔥", _converter.ToEmoji("fire"));
            Assert.AreEqual("❤️", _converter.ToEmoji("love"));
            Assert.AreEqual("⭐", _converter.ToEmoji("star"));
            Assert.AreEqual("🐶", _converter.ToEmoji("dog"));
            Assert.AreEqual("🐱", _converter.ToEmoji("cat"));
            Assert.AreEqual("🐄", _converter.ToEmoji("cow"));
            Assert.AreEqual("☀️", _converter.ToEmoji("sun"));
            Assert.AreEqual("🌙", _converter.ToEmoji("moon"));
            Assert.AreEqual("🌧️", _converter.ToEmoji("rain"));
            Assert.AreEqual("❄️", _converter.ToEmoji("snow"));
            Assert.AreEqual("☕", _converter.ToEmoji("coffee"));
            Assert.AreEqual("🎵", _converter.ToEmoji("music"));
            Assert.AreEqual("🎉", _converter.ToEmoji("party"));
            Assert.AreEqual("🍕", _converter.ToEmoji("pizza"));
            Assert.AreEqual("🎂", _converter.ToEmoji("cake"));
            Assert.AreEqual("💰", _converter.ToEmoji("money"));
            Assert.AreEqual("👍", _converter.ToEmoji("thumbsup"));
            Assert.AreEqual("❓", _converter.ToEmoji("question"));
        }

        [Test]
        public void ToEmoji_ReturnsQuestionMark_ForUnknownWord()
        {
            Assert.AreEqual("❓", _converter.ToEmoji("unknown"));
            Assert.AreEqual("❓", _converter.ToEmoji("foobar"));
        }
    }
}
