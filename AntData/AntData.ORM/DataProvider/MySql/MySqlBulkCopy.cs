﻿using System;
using System.Collections.Generic;

namespace AntData.ORM.DataProvider.MySql
{
	using Data;

	class MySqlBulkCopy : BasicBulkCopy
	{
		protected override BulkCopyRowsCopied MultipleRowsCopy<T>(
			DataConnection dataConnection, BulkCopyOptions options, IEnumerable<T> source)
		{
			return MultipleRowsCopy1(dataConnection, options, false, source);
		}
	}
}
