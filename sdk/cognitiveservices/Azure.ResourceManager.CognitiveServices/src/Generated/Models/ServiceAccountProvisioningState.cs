// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Gets the status of the cognitive services account at the time the operation was called. </summary>
    public readonly partial struct ServiceAccountProvisioningState : IEquatable<ServiceAccountProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceAccountProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceAccountProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string MovingValue = "Moving";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string ResolvingDnsValue = "ResolvingDNS";

        /// <summary> Accepted. </summary>
        public static ServiceAccountProvisioningState Accepted { get; } = new ServiceAccountProvisioningState(AcceptedValue);
        /// <summary> Creating. </summary>
        public static ServiceAccountProvisioningState Creating { get; } = new ServiceAccountProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static ServiceAccountProvisioningState Deleting { get; } = new ServiceAccountProvisioningState(DeletingValue);
        /// <summary> Moving. </summary>
        public static ServiceAccountProvisioningState Moving { get; } = new ServiceAccountProvisioningState(MovingValue);
        /// <summary> Failed. </summary>
        public static ServiceAccountProvisioningState Failed { get; } = new ServiceAccountProvisioningState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static ServiceAccountProvisioningState Succeeded { get; } = new ServiceAccountProvisioningState(SucceededValue);
        /// <summary> ResolvingDNS. </summary>
        public static ServiceAccountProvisioningState ResolvingDns { get; } = new ServiceAccountProvisioningState(ResolvingDnsValue);
        /// <summary> Determines if two <see cref="ServiceAccountProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ServiceAccountProvisioningState left, ServiceAccountProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceAccountProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ServiceAccountProvisioningState left, ServiceAccountProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceAccountProvisioningState"/>. </summary>
        public static implicit operator ServiceAccountProvisioningState(string value) => new ServiceAccountProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceAccountProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceAccountProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
