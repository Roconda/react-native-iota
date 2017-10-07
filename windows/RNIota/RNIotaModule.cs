using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Iota.RNIota
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNIotaModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNIotaModule"/>.
        /// </summary>
        internal RNIotaModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNIota";
            }
        }
    }
}
