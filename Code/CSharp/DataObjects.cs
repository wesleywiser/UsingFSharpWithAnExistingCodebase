using System;

namespace Examples
{
	public sealed class Contact : IEquatable<Contact>
	{
		public string Name { get; private set; }
		public string PhysicalAddress { get; private set; }
		public string EmailAddress { get; private set; }

		public Contact(string name, string physicalAddress, string emailAddress)
		{
			Name = name;
			PhysicalAddress = physicalAddress;
			EmailAddress = emailAddress;
		}

		public override bool Equals(object other)
		{
			return Equals(other as Contact);
		}

		public bool Equals(Contact other)
		{
			if (other == null)
				return false;

			return
				Name == other.Name &&
				PhysicalAddress == other.PhysicalAddress &&
				EmailAddress == other.EmailAddress;
		}

		public override int GetHashCode()
		{
			int hash = 17;
			hash = hash * 23 + Name.GetHashCode();
			hash = hash * 23 + PhysicalAddress.GetHashCode();
			hash = hash * 23 + EmailAddress.GetHashCode();

			return hash;
		}

		public override string ToString()
		{
			return string.Format("{{ Name: '{0}', PhysicalAddress: '{1}', EmailAddress: '{2}' }}", Name, PhysicalAddress, EmailAddress);
		}
	}
}
