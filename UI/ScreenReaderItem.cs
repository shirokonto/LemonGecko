
namespace Launcher
{
    /// <summary>
    /// The class <c>ScreenReaderItem</c> contains the name of the screen reader and the mappings of the gestures to the set keys.
    /// </summary>
    public class ScreenReaderItem
    {
        /// <summary>
        /// Constructs a <c>ScreenReaderItem</c> object.
        /// </summary>
        public ScreenReaderItem()
        {
        }

        /// <summary>Gets the name of the screen reader.</summary>
        public string Name { get; set; }
        /// <summary>Gets and sets the keys for the ScreenTap gesture.</summary>
        public string ScreenTap { get; set; }
        /// <summary>Gets and sets the keys for the HandSwipeRight gesture.</summary>
        public string HandSwipeRight { get; set; }
        /// <summary>Gets and sets the keys for the HandSwipeLeft gesture.</summary>
        public string HandSwipeLeft { get; set; }
        /// <summary>Gets and sets the keys for the HandSwipeUp gesture.</summary>
        public string HandSwipeUp { get; set; }
        /// <summary>Gets and sets the keys for the HandSwipeDown gesture.</summary>
        public string HandSwipeDown { get; set; }
        /// <summary>Gets and sets the keys for the CircleClockwise gesture.</summary>
        public string CircleClockwise { get; set; }
        /// <summary>Gets and sets the keys for the CircleCounterClockwise gesture.</summary>
        public string CircleCounterClockwise { get; set; }
        /// <summary>Gets and sets the keys for the Punch gesture.</summary>
        public string Punch { get; set;}
    }
}
