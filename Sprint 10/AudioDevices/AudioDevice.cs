﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudioDevices
{
    public abstract class AudioDevice
    {

        #region Fields and Properties
        /// <summary>
        /// The BTW percentage
        /// </summary>
        protected readonly static double btwPercentage = 19.0;

        /// <summary>
        /// The last identifier
        /// </summary>
        protected static int _lastId = 0;

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the make.
        /// </summary>
        /// <value>
        /// The make.
        /// </value>
        public string Make { get; set; }

        /// <summary>
        /// Gets or sets the price ex BTW.
        /// </summary>
        /// <value>
        /// The price ex BTW.
        /// </value>
        public decimal PriceExBtw { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>
        /// The creation date.
        /// </value>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets the serial identifier.
        /// </summary>
        /// <value>
        /// The serial identifier.
        /// </value>
        public int SerialId { get; set; }

        /// <summary>
        /// Gets the consumer price.
        /// </summary>
        /// <value>
        /// The consumer price.
        /// </value>
        public decimal ConsumerPrice
        {
            get { return PriceExBtw * (100 + (decimal)btwPercentage) / 100; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Displays the identity.
        /// </summary>
        /// <returns></returns>
        public string DisplayIdentity()
        {
            return $"Serialid: {SerialId}";
        }

        /// <summary>
        /// Displays the identity.
        /// </summary>
        /// <param name="modelInfo">if set to <c>true</c> [model information].</param>
        /// <param name="makeInfo">if set to <c>true</c> [make information].</param>
        /// <returns></returns>
        public string DisplayIdentity(bool modelInfo, bool makeInfo)
        {
            string info = "Serialid: " + this.SerialId;
            if (modelInfo)
            {
                info += "\nModel: " + this.Model;
            }
            if (makeInfo)
            {
                info += "\nMake: " + this.Make;
            }
            return info;
        }

        /// <summary>
        /// Gets the device lifetime.
        /// </summary>
        /// <returns></returns>
        public string GetDeviceLifetime()
        {
            int daysDiff = (DateTime.Now - CreationDate).Days;
            return $"Lifetime {daysDiff} days";
        }

        /// <summary>
        /// Displays the storage capacity.
        /// </summary>
        /// <returns></returns>
        public abstract string DisplayStorageCapacity();

        #endregion

    }
}