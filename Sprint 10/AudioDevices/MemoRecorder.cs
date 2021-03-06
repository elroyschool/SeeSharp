﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudioDevices
{
    public class MemoRecorder : AudioDevice
    {

        #region Fields and properties

        /// <summary>
        /// The maximum cartridge type
        /// </summary>
        private MemoCartridgeType maxCartridgeType;

        /// <summary>
        /// Gets or sets the maximum capacity type of the cartridge.
        /// </summary>
        /// <value>
        /// The maximum capacity type of the cartridge.
        /// </value>
        public MemoCartridgeType MaxCartridgeType
        {
            get { return maxCartridgeType; }
            set { maxCartridgeType = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="MemoRecorder"/> class.
        /// </summary>
        public MemoRecorder()
        {
            this.SerialId = ++MemoRecorder._lastId;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Displays the storage capacity.
        /// </summary>
        /// <returns></returns>
        public override string DisplayStorageCapacity()
        {
            string storage = "Max. capacity ";
            switch (MaxCartridgeType)
            {
                case MemoCartridgeType.C60:
                    storage += "60 minutes.";
                    break;
                case MemoCartridgeType.C90:
                    storage += "90 minutes.";
                    break;
                case MemoCartridgeType.C120:
                    storage += "120 minutes.";
                    break;
                default:
                    storage += "unknown.";
                    break;
            }
            return storage;
        }

        #endregion

    }
}