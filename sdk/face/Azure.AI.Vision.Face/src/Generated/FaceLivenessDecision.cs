// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Vision.Face
{
    /// <summary> The outcome of the liveness classification. </summary>
    public readonly partial struct FaceLivenessDecision : IEquatable<FaceLivenessDecision>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FaceLivenessDecision"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FaceLivenessDecision(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UncertainValue = "uncertain";
        private const string RealFaceValue = "realface";
        private const string SpoofFaceValue = "spoofface";

        /// <summary> The algorithm could not classify the target face as either real or spoof. </summary>
        public static FaceLivenessDecision Uncertain { get; } = new FaceLivenessDecision(UncertainValue);
        /// <summary> The algorithm has classified the target face as real. </summary>
        public static FaceLivenessDecision RealFace { get; } = new FaceLivenessDecision(RealFaceValue);
        /// <summary> The algorithm has classified the target face as a spoof. </summary>
        public static FaceLivenessDecision SpoofFace { get; } = new FaceLivenessDecision(SpoofFaceValue);
        /// <summary> Determines if two <see cref="FaceLivenessDecision"/> values are the same. </summary>
        public static bool operator ==(FaceLivenessDecision left, FaceLivenessDecision right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FaceLivenessDecision"/> values are not the same. </summary>
        public static bool operator !=(FaceLivenessDecision left, FaceLivenessDecision right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FaceLivenessDecision"/>. </summary>
        public static implicit operator FaceLivenessDecision(string value) => new FaceLivenessDecision(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FaceLivenessDecision other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FaceLivenessDecision other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
