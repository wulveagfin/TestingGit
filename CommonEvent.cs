namespace Global.Business.Events
{
	using System;

	public delegate void CommonEventHandlerInt(object sender, CommonEventHandlerArgsInt e);

	public sealed class CommonEventHandlerArgsInt : EventArgs
	{
		public int? Value;

		public CommonEventHandlerArgsInt()
		{
		}

		public CommonEventHandlerArgsInt(int? value)
		{
			this.Value = value;
		}
	}


	public delegate void CommonEventHandlerDouble(object sender, CommonEventHandlerArgsDouble e);

	public sealed class CommonEventHandlerArgsDouble : EventArgs
	{
		public Double? Value;

		public CommonEventHandlerArgsDouble()
		{
		}

		public CommonEventHandlerArgsDouble(Double? value)
		{
			this.Value = value;
		}
	}


	public delegate void CommonEventHandlerDecimal(object sender, CommonEventHandlerArgsDecimal e);

	public sealed class CommonEventHandlerArgsDecimal : EventArgs
	{
		public Decimal? Value;

		public CommonEventHandlerArgsDecimal()
		{
		}

		public CommonEventHandlerArgsDecimal(Decimal? value)
		{
			this.Value = value;
		}
	}





	public delegate void CommonEventHandlerObject(object sender, CommonEventHandlerArgsObject e);

	public sealed class CommonEventHandlerArgsObject : EventArgs
	{
		public Object Value;

		public CommonEventHandlerArgsObject()
		{
		}

		public CommonEventHandlerArgsObject(Object value)
		{
			this.Value = value;
		}
	}





	public delegate void CommonEventHandlerString(object sender, CommonEventHandlerArgsString e);

	public sealed class CommonEventHandlerArgsString : EventArgs
	{
		public String Value;

		public CommonEventHandlerArgsString()
		{
		}

		public CommonEventHandlerArgsString(String value)
		{
			this.Value = value;
		}
	}



	public delegate void CommonEventHandlerBool(object sender, CommonEventHandlerArgsBool e);

	public sealed class CommonEventHandlerArgsBool : EventArgs
	{
		public bool? Value;

		public CommonEventHandlerArgsBool()
		{
		}

		public CommonEventHandlerArgsBool(bool? value)
		{
			this.Value = value;
		}
	}



}
