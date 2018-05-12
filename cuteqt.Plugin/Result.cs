using System.Windows.Media.Imaging;

namespace cuteqt.Plugin
{
    /// <summary>
    /// Class: 'Result'
    /// </summary>
    public class Result
    {
        #region Properties 
        
        /// <summary>
        /// Displayed text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Displayed text under the priority text.
        /// </summary>
        public string SubText { get; set; }

        /// <summary>
        /// Displayed icon.
        /// </summary>
        public BitmapImage Icon { get; set; }

        #endregion

        #region Constructor 

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="text">Displayed text.</param>
        /// <param name="subText">Displayed text under the priority text.</param>
        /// <param name="icon">Displayed icon.</param>
        public Result(string text, string subText, BitmapImage icon)
        {
            Text = text;
            SubText = subText;
            Icon = icon;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Result() { }

        #endregion 
    }
}