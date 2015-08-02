﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAHW.Model
{
	/// <summary>
	/// <para>
	/// Class that represents a configuration setting
	/// </para>
	/// 
	/// <para>
	/// Class history:
	/// <list type="bullet">
	///     <item>
	///         <description>1.0: First release, working (Steffen Steinbrecher).</description>
	///     </item>
	/// </list>
	/// </para>
	/// 
	/// <para>Author: Steffen Steinbrecher</para>
	/// <para>Date: 29.07.2015</para>
	/// </summary>
	public class ConfigurationSetting
	{
		#region CTOR

		/// <summary>
		/// CTOR
		/// </summary>
		/// <param name="name"></param>
		/// <param name="defaultValue"></param>
		public ConfigurationSetting(string name, string defaultValue)
		{
			this.Name = name;
			this.DefaultValue = defaultValue;
		}

		/// <summary>
		/// CTOR
		/// </summary>
		/// <param name="name"></param>
		/// <param name="defaultValue"></param>
		public ConfigurationSetting(string name, string defaultValue, string value, Type dataType)
		{
			this.Name = name;
			this.DefaultValue = defaultValue;
			this.Value = value;
			this.DataType = dataType;
		}

		#endregion CTOR

		#region Properties

		private string name;

		/// <summary>
		/// Name of the setting
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string value;

		/// <summary>
		/// Value of the setting
		/// </summary>
		public string Value
		{
			get { return value; }
			set { this.value = value; }
		}

		private string defaultValue;

		/// <summary>
		/// Default value of the setting
		/// </summary>
		public string DefaultValue
		{
			get { return defaultValue; }
			set { defaultValue = value; }
		}

		private Type dataType = typeof(System.String);

		/// <summary>
		/// The datatype of the setting
		/// </summary>
		public Type DataType
		{
			get { return this.dataType; }
			set { this.dataType = value; }
		}

		private bool wasInFile;

		/// <summary>
		/// Flag if setting was in file
		/// </summary>
		public bool WasInFile
		{
			get { return wasInFile; }
			set { wasInFile = value; }
		}		

		#endregion Properties
	}
}
