/*
 * Created by SharpDevelop.
 * User: S133007547
 * Date: 3/1/2017
 * Time: 1:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;   
using System.Configuration;

namespace FSync
{
	/// <summary>
	/// Represents a single XML tag inside a ConfigurationSection
	/// or a ConfigurationElementCollection.
	/// </summary>
	public sealed class SettingsElement : ConfigurationElement
	{
		/// <summary>
		/// The attribute <c>name</c> of a <c>SettingsElement</c>.
		/// </summary>
		[ConfigurationProperty("name", IsKey = true, IsRequired = true)]
		public string Name
		{
			get { return (string)this["name"]; }
			set { this["name"] = value; }
		}
	
	
		/// <summary>
		/// A demonstration of how to use a boolean property.
		/// </summary>
		[ConfigurationProperty("special")]
		public bool IsSpecial {
			get { return (bool)this["special"]; }
			set { this["special"] = value; }
		}
	}
	
}

