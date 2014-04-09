﻿using System;
using DirectOutput.Cab.Toys.Layer;
using DirectOutput.General.Analog;
namespace DirectOutput.Cab.Toys
{
    /// <summary>
    /// Common interface for toys supporting analog alpha layers.
    /// </summary>
    public interface IAnalogAlphaToy : IToy, ILayerToy<AnalogAlpha>
    {
        /// <summary>
        /// Finishes the toy.
        /// </summary>
        void Finish();
        /// <summary>
        /// Initializes the toy.
        /// </summary>
        /// <param name="Cabinet">The cabinet object containing the toy.</param>
        void Init(DirectOutput.Cab.Cabinet Cabinet);
        /// <summary>
        /// Gets the dictionary of AnalogAlphaLayers.
        /// </summary>
        /// <value>
        /// The layers dictionary.
        /// </value>
        LayerDictionary<AnalogAlpha> Layers { get; }


        /// <summary>
        /// Resets the toy.
        /// </summary>
        void Reset();

    }
}
