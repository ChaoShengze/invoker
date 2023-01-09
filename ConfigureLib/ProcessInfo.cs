using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigureLib
{
    public class ProcessInfo
    {
        /// <summary>
        /// Path of file.
        /// </summary>
        public string FilePath { get; set; } = string.Empty;
        /// <summary>
        /// Name of process.
        /// </summary>
        public string ProcessName { get; set; } = string.Empty;
        /// <summary>
        /// State of process.
        /// </summary>
        public ProcessState ProcessState { get; set; } = ProcessState.DIE;
    }

    public enum ProcessState 
    { 
        ALIVE = 0,
        DIE
    }
}
