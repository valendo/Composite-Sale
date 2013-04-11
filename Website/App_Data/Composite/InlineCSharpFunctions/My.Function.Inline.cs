using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Composite.Data;
using Composite.Data.Types;

namespace My.Function
{
	public static class InlineMethodFunction
	{
		public static string Inline(int myIntValue, string myStringValue)
		{
			return "Inline function";
		}
	}
}
