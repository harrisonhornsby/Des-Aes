using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DES
{
	class Plaintext
	{
		/// <summary>
		/// This represents the plain text value
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// This is the plain text after encoded into a byte array
		/// </summary>
		public byte[] EncodedValue { get; set; }
	}
}
