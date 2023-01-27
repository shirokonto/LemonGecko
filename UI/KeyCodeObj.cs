
namespace Launcher
{
    /// <summary>
    /// The class <c>KeyCodeObj</c> stores the key-to-code mapping (e.g. ENTER to {ENTER}).
    /// The key is displayed in the settings view and can only be one keystroke
    /// The code is used for the keystroke simulation and can consist of up to two keystrokes.
    /// </summary>
    class KeyCodeObj
    {
        /// <summary>Gets and sets the Key property.</summary>
        public string Key { get; set; }
        /// <summary>Gets and sets the Code property.</summary>
        public string Code { get; set; }
    }
}
