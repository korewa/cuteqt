using System;

namespace cuteqt.Plugin
{
    /// <summary>
    /// Class: 'PluginMetadata'
    /// </summary>
    public class PluginMetadata
    {
        #region Properties

        /// <summary>
        /// Name of the plugin.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the plugin.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Author of the plugin.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Website of the plugin/author.
        /// </summary>
        public Uri Website { get; set; }

        /// <summary>
        /// Version of the plugin.
        /// </summary>
        public Version Version { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the plugin.</param>
        /// <param name="description">Description of the plugin.</param>
        /// <param name="author">Author of the plugin.</param>
        /// <param name="website">Website of the plugin/author.</param>
        /// <param name="version">Version of the plugin.</param>
        public PluginMetadata(string name, string description, string author, Uri website, Version version)
        {
            Name = name;
            Description = description;
            Author = author;
            Website = website;
            Version = version;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public PluginMetadata() { }

        #endregion
    }
}