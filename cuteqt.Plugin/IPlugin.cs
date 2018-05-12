using System.Collections.Generic;

namespace cuteqt.Plugin
{
    /// <summary>
    /// Interface: 'IPlugin'
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Function that returns a list of results.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Result> Search();

        /// <summary>
        /// Initiating the plugin and setting the metadata.
        /// </summary>
        /// <param name="metadata"></param>
        void Init(PluginMetadata metadata);
    }
}