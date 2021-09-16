using System;
using System.Data;
using AdoNet.Specification.Tests;

namespace Conformance.Tests;

public class GetValueConversionTests : GetValueConversionTestBase<SelectValueFixture>
{
	public GetValueConversionTests(SelectValueFixture fixture)
		: base(fixture)
	{
	}

	// GetBoolean allows conversions from any integral type and decimal for backwards compatibility
	public override void GetBoolean_throws_for_maximum_Byte() => TestGetValue(DbType.Byte, ValueKind.Maximum, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_maximum_Byte_with_GetFieldValue() => TestGetValue(DbType.Byte, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_maximum_Int16() => TestGetValue(DbType.Int16, ValueKind.Maximum, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_maximum_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_maximum_Int32() => TestGetValue(DbType.Int32, ValueKind.Maximum, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_maximum_Int32_with_GetFieldValue() => TestGetValue(DbType.Int32, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_maximum_Int64() => TestGetValue(DbType.Int64, ValueKind.Maximum, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_maximum_Int64_with_GetFieldValue() => TestGetValue(DbType.Int64, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_maximum_SByte() => TestGetValue(DbType.SByte, ValueKind.Maximum, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_maximum_SByte_with_GetFieldValue() => TestGetValue(DbType.SByte, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_maximum_UInt16() => TestGetValue(DbType.UInt16, ValueKind.Maximum, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_maximum_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_maximum_UInt32() => TestGetValue(DbType.UInt32, ValueKind.Maximum, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_maximum_UInt32_with_GetFieldValue() => TestGetValue(DbType.UInt32, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_maximum_UInt64() => TestGetValue(DbType.UInt64, ValueKind.Maximum, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_maximum_UInt64_with_GetFieldValue() => TestGetValue(DbType.UInt64, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_maximum_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Maximum, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_maximum_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_minimum_Byte() => TestGetValue(DbType.Byte, ValueKind.Minimum, x => x.GetBoolean(0), false);
	public override void GetBoolean_throws_for_minimum_Byte_with_GetFieldValue() => TestGetValue(DbType.Byte, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), false);
	public override void GetBoolean_throws_for_minimum_Int16() => TestGetValue(DbType.Int16, ValueKind.Minimum, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_minimum_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_minimum_Int32() => TestGetValue(DbType.Int32, ValueKind.Minimum, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_minimum_Int32_with_GetFieldValue() => TestGetValue(DbType.Int32, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_minimum_Int64() => TestGetValue(DbType.Int64, ValueKind.Minimum, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_minimum_Int64_with_GetFieldValue() => TestGetValue(DbType.Int64, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_minimum_SByte() => TestGetValue(DbType.SByte, ValueKind.Minimum, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_minimum_SByte_with_GetFieldValue() => TestGetValue(DbType.SByte, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_minimum_UInt16() => TestGetValue(DbType.UInt16, ValueKind.Minimum, x => x.GetBoolean(0), false);
	public override void GetBoolean_throws_for_minimum_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), false);
	public override void GetBoolean_throws_for_minimum_UInt32() => TestGetValue(DbType.UInt32, ValueKind.Minimum, x => x.GetBoolean(0), false);
	public override void GetBoolean_throws_for_minimum_UInt32_with_GetFieldValue() => TestGetValue(DbType.UInt32, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), false);
	public override void GetBoolean_throws_for_minimum_UInt64() => TestGetValue(DbType.UInt64, ValueKind.Minimum, x => x.GetBoolean(0), false);
	public override void GetBoolean_throws_for_minimum_UInt64_with_GetFieldValue() => TestGetValue(DbType.UInt64, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), false);
	public override void GetBoolean_throws_for_minimum_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Minimum, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_minimum_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_one_Byte() => TestGetValue(DbType.Byte, ValueKind.One, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_one_Byte_with_GetFieldValue() => TestGetValue(DbType.Byte, ValueKind.One, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_one_Int16() => TestGetValue(DbType.Int16, ValueKind.One, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_one_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.One, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_one_Int32() => TestGetValue(DbType.Int32, ValueKind.One, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_one_Int32_with_GetFieldValue() => TestGetValue(DbType.Int32, ValueKind.One, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_one_Int64() => TestGetValue(DbType.Int64, ValueKind.One, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_one_Int64_with_GetFieldValue() => TestGetValue(DbType.Int64, ValueKind.One, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_one_SByte() => TestGetValue(DbType.SByte, ValueKind.One, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_one_SByte_with_GetFieldValue() => TestGetValue(DbType.SByte, ValueKind.One, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_one_UInt16() => TestGetValue(DbType.UInt16, ValueKind.One, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_one_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.One, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_one_UInt32() => TestGetValue(DbType.UInt32, ValueKind.One, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_one_UInt32_with_GetFieldValue() => TestGetValue(DbType.UInt32, ValueKind.One, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_one_UInt64() => TestGetValue(DbType.UInt64, ValueKind.One, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_one_UInt64_with_GetFieldValue() => TestGetValue(DbType.UInt64, ValueKind.One, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_one_Decimal() => TestGetValue(DbType.Decimal, ValueKind.One, x => x.GetBoolean(0), true);
	public override void GetBoolean_throws_for_one_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.One, x => x.GetFieldValue<bool>(0), true);
	public override void GetBoolean_throws_for_zero_Byte() => TestGetValue(DbType.Byte, ValueKind.Zero, x => x.GetBoolean(0), false);
	public override void GetBoolean_throws_for_zero_Byte_with_GetFieldValue() => TestGetValue(DbType.Byte, ValueKind.Zero, x => x.GetFieldValue<bool>(0), false);
	public override void GetBoolean_throws_for_zero_Int16() => TestGetValue(DbType.Int16, ValueKind.Zero, x => x.GetBoolean(0), false);
	public override void GetBoolean_throws_for_zero_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.Zero, x => x.GetFieldValue<bool>(0), false);
	public override void GetBoolean_throws_for_zero_Int32() => TestGetValue(DbType.Int32, ValueKind.Zero, x => x.GetBoolean(0), false);
	public override void GetBoolean_throws_for_zero_Int32_with_GetFieldValue() => TestGetValue(DbType.Int32, ValueKind.Zero, x => x.GetFieldValue<bool>(0), false);
	public override void GetBoolean_throws_for_zero_Int64() => TestGetValue(DbType.Int64, ValueKind.Zero, x => x.GetBoolean(0), false);
	public override void GetBoolean_throws_for_zero_Int64_with_GetFieldValue() => TestGetValue(DbType.Int64, ValueKind.Zero, x => x.GetFieldValue<bool>(0), false);
	public override void GetBoolean_throws_for_zero_SByte() => TestGetValue(DbType.SByte, ValueKind.Zero, x => x.GetBoolean(0), false);
	public override void GetBoolean_throws_for_zero_SByte_with_GetFieldValue() => TestGetValue(DbType.SByte, ValueKind.Zero, x => x.GetFieldValue<bool>(0), false);
	public override void GetBoolean_throws_for_zero_UInt16() => TestGetValue(DbType.UInt16, ValueKind.Zero, x => x.GetBoolean(0), false);
	public override void GetBoolean_throws_for_zero_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.Zero, x => x.GetFieldValue<bool>(0), false);
	public override void GetBoolean_throws_for_zero_UInt32() => TestGetValue(DbType.UInt32, ValueKind.Zero, x => x.GetBoolean(0), false);
	public override void GetBoolean_throws_for_zero_UInt32_with_GetFieldValue() => TestGetValue(DbType.UInt32, ValueKind.Zero, x => x.GetFieldValue<bool>(0), false);
	public override void GetBoolean_throws_for_zero_UInt64() => TestGetValue(DbType.UInt64, ValueKind.Zero, x => x.GetBoolean(0), false);
	public override void GetBoolean_throws_for_zero_UInt64_with_GetFieldValue() => TestGetValue(DbType.UInt64, ValueKind.Zero, x => x.GetFieldValue<bool>(0), false);
	public override void GetBoolean_throws_for_zero_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Zero, x => x.GetBoolean(0), false);
	public override void GetBoolean_throws_for_zero_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.Zero, x => x.GetFieldValue<bool>(0), false);

	// BOOL columns can be coerced to integers: https://github.com/mysql-net/MySqlConnector/issues/782
	public override void GetByte_throws_for_minimum_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Minimum, x => x.GetByte(0), (byte) 0);
	public override void GetByte_throws_for_minimum_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), (byte) 0);
	public override void GetByte_throws_for_zero_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Zero, x => x.GetByte(0), (byte) 0);
	public override void GetByte_throws_for_zero_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.Zero, x => x.GetFieldValue<byte>(0), (byte) 0);
	public override void GetByte_throws_for_one_Boolean() => TestGetValue(DbType.Boolean, ValueKind.One, x => x.GetByte(0), (byte) 1);
	public override void GetByte_throws_for_one_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.One, x => x.GetFieldValue<byte>(0), (byte) 1);
	public override void GetByte_throws_for_maximum_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Maximum, x => x.GetByte(0), (byte) 1);
	public override void GetByte_throws_for_maximum_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), (byte) 1);
	public override void GetInt16_throws_for_minimum_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Minimum, x => x.GetInt16(0), (short) 0);
	public override void GetInt16_throws_for_minimum_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.Minimum, x => x.GetFieldValue<short>(0), (short) 0);
	public override void GetInt16_throws_for_zero_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Zero, x => x.GetInt16(0), (short) 0);
	public override void GetInt16_throws_for_zero_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.Zero, x => x.GetFieldValue<short>(0), (short) 0);
	public override void GetInt16_throws_for_one_Boolean() => TestGetValue(DbType.Boolean, ValueKind.One, x => x.GetInt16(0), (short) 1);
	public override void GetInt16_throws_for_one_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.One, x => x.GetFieldValue<short>(0), (short) 1);
	public override void GetInt16_throws_for_maximum_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Maximum, x => x.GetInt16(0), (short) 1);
	public override void GetInt16_throws_for_maximum_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.Maximum, x => x.GetFieldValue<short>(0), (short) 1);
	public override void GetInt32_throws_for_minimum_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Minimum, x => x.GetInt32(0), 0);
	public override void GetInt32_throws_for_minimum_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.Minimum, x => x.GetFieldValue<int>(0), 0);
	public override void GetInt32_throws_for_zero_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Zero, x => x.GetInt32(0), 0);
	public override void GetInt32_throws_for_zero_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.Zero, x => x.GetFieldValue<int>(0), 0);
	public override void GetInt32_throws_for_one_Boolean() => TestGetValue(DbType.Boolean, ValueKind.One, x => x.GetInt32(0), 1);
	public override void GetInt32_throws_for_one_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.One, x => x.GetFieldValue<int>(0), 1);
	public override void GetInt32_throws_for_maximum_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Maximum, x => x.GetInt32(0), 1);
	public override void GetInt32_throws_for_maximum_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.Maximum, x => x.GetFieldValue<int>(0), 1);
	public override void GetInt64_throws_for_minimum_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Minimum, x => x.GetInt64(0), 0L);
	public override void GetInt64_throws_for_minimum_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.Minimum, x => x.GetFieldValue<long>(0), 0L);
	public override void GetInt64_throws_for_zero_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Zero, x => x.GetInt64(0), 0L);
	public override void GetInt64_throws_for_zero_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.Zero, x => x.GetFieldValue<long>(0), 0L);
	public override void GetInt64_throws_for_one_Boolean() => TestGetValue(DbType.Boolean, ValueKind.One, x => x.GetInt64(0), 1L);
	public override void GetInt64_throws_for_one_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.One, x => x.GetFieldValue<long>(0), 1L);
	public override void GetInt64_throws_for_maximum_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Maximum, x => x.GetInt64(0), 1L);
	public override void GetInt64_throws_for_maximum_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.Maximum, x => x.GetFieldValue<long>(0), 1L);

	// GetByte allows integral conversions
	public override void GetByte_throws_for_maximum_Int16() => TestException(DbType.Int16, ValueKind.Maximum, x => x.GetByte(0), typeof(OverflowException));
	public override void GetByte_throws_for_maximum_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(OverflowException));
	public override void GetByte_throws_for_maximum_Int32() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetByte(0), typeof(OverflowException));
	public override void GetByte_throws_for_maximum_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(OverflowException));
	public override void GetByte_throws_for_maximum_Int64() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetByte(0), typeof(OverflowException));
	public override void GetByte_throws_for_maximum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(OverflowException));
	public override void GetByte_throws_for_maximum_SByte() => TestGetValue(DbType.SByte, ValueKind.Maximum, x => x.GetByte(0), (byte) 127);
	public override void GetByte_throws_for_maximum_SByte_with_GetFieldValue() => TestGetValue(DbType.SByte, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), (byte) 127);
	public override void GetByte_throws_for_maximum_UInt16() => TestException(DbType.UInt16, ValueKind.Maximum, x => x.GetByte(0), typeof(OverflowException));
	public override void GetByte_throws_for_maximum_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(OverflowException));
	public override void GetByte_throws_for_maximum_UInt32() => TestException(DbType.UInt32, ValueKind.Maximum, x => x.GetByte(0), typeof(OverflowException));
	public override void GetByte_throws_for_maximum_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(OverflowException));
	public override void GetByte_throws_for_maximum_UInt64() => TestException(DbType.UInt64, ValueKind.Maximum, x => x.GetByte(0), typeof(OverflowException));
	public override void GetByte_throws_for_maximum_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(OverflowException));
	public override void GetByte_throws_for_maximum_Decimal() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetByte(0), typeof(OverflowException));
	public override void GetByte_throws_for_maximum_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(OverflowException));
	public override void GetByte_throws_for_minimum_Int16() => TestException(DbType.Int16, ValueKind.Minimum, x => x.GetByte(0), typeof(OverflowException));
	public override void GetByte_throws_for_minimum_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(OverflowException));
	public override void GetByte_throws_for_minimum_Int32() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetByte(0), typeof(OverflowException));
	public override void GetByte_throws_for_minimum_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(OverflowException));
	public override void GetByte_throws_for_minimum_Int64() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetByte(0), typeof(OverflowException));
	public override void GetByte_throws_for_minimum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(OverflowException));
	public override void GetByte_throws_for_minimum_SByte() => TestException(DbType.SByte, ValueKind.Minimum, x => x.GetByte(0), typeof(OverflowException));
	public override void GetByte_throws_for_minimum_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(OverflowException));
	public override void GetByte_throws_for_minimum_UInt16() => TestGetValue(DbType.UInt16, ValueKind.Minimum, x => x.GetByte(0), (byte) 0);
	public override void GetByte_throws_for_minimum_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), (byte) 0);
	public override void GetByte_throws_for_minimum_UInt32() => TestGetValue(DbType.UInt32, ValueKind.Minimum, x => x.GetByte(0), (byte) 0);
	public override void GetByte_throws_for_minimum_UInt32_with_GetFieldValue() => TestGetValue(DbType.UInt32, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), (byte) 0);
	public override void GetByte_throws_for_minimum_UInt64() => TestGetValue(DbType.UInt64, ValueKind.Minimum, x => x.GetByte(0), (byte) 0);
	public override void GetByte_throws_for_minimum_UInt64_with_GetFieldValue() => TestGetValue(DbType.UInt64, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), (byte) 0);
	public override void GetByte_throws_for_minimum_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Minimum, x => x.GetByte(0), (byte) 0);
	public override void GetByte_throws_for_minimum_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), (byte) 0);
	public override void GetByte_throws_for_one_Int16() => TestGetValue(DbType.Int16, ValueKind.One, x => x.GetByte(0), (byte) 1);
	public override void GetByte_throws_for_one_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.One, x => x.GetFieldValue<byte>(0), (byte) 1);
	public override void GetByte_throws_for_one_Int32() => TestGetValue(DbType.Int32, ValueKind.One, x => x.GetByte(0), (byte) 1);
	public override void GetByte_throws_for_one_Int32_with_GetFieldValue() => TestGetValue(DbType.Int32, ValueKind.One, x => x.GetFieldValue<byte>(0), (byte) 1);
	public override void GetByte_throws_for_one_Int64() => TestGetValue(DbType.Int64, ValueKind.One, x => x.GetByte(0), (byte) 1);
	public override void GetByte_throws_for_one_Int64_with_GetFieldValue() => TestGetValue(DbType.Int64, ValueKind.One, x => x.GetFieldValue<byte>(0), (byte) 1);
	public override void GetByte_throws_for_one_SByte() => TestGetValue(DbType.SByte, ValueKind.One, x => x.GetByte(0), (byte) 1);
	public override void GetByte_throws_for_one_SByte_with_GetFieldValue() => TestGetValue(DbType.SByte, ValueKind.One, x => x.GetFieldValue<byte>(0), (byte) 1);
	public override void GetByte_throws_for_one_UInt16() => TestGetValue(DbType.UInt16, ValueKind.One, x => x.GetByte(0), (byte) 1);
	public override void GetByte_throws_for_one_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.One, x => x.GetFieldValue<byte>(0), (byte) 1);
	public override void GetByte_throws_for_one_UInt32() => TestGetValue(DbType.UInt32, ValueKind.One, x => x.GetByte(0), (byte) 1);
	public override void GetByte_throws_for_one_UInt32_with_GetFieldValue() => TestGetValue(DbType.UInt32, ValueKind.One, x => x.GetFieldValue<byte>(0), (byte) 1);
	public override void GetByte_throws_for_one_UInt64() => TestGetValue(DbType.UInt64, ValueKind.One, x => x.GetByte(0), (byte) 1);
	public override void GetByte_throws_for_one_UInt64_with_GetFieldValue() => TestGetValue(DbType.UInt64, ValueKind.One, x => x.GetFieldValue<byte>(0), (byte) 1);
	public override void GetByte_throws_for_one_Decimal() => TestGetValue(DbType.Decimal, ValueKind.One, x => x.GetByte(0), (byte) 1);
	public override void GetByte_throws_for_one_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.One, x => x.GetFieldValue<byte>(0), (byte) 1);
	public override void GetByte_throws_for_zero_Int16() => TestGetValue(DbType.Int16, ValueKind.Zero, x => x.GetByte(0), (byte) 0);
	public override void GetByte_throws_for_zero_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.Zero, x => x.GetFieldValue<byte>(0), (byte) 0);
	public override void GetByte_throws_for_zero_Int32() => TestGetValue(DbType.Int32, ValueKind.Zero, x => x.GetByte(0), (byte) 0);
	public override void GetByte_throws_for_zero_Int32_with_GetFieldValue() => TestGetValue(DbType.Int32, ValueKind.Zero, x => x.GetFieldValue<byte>(0), (byte) 0);
	public override void GetByte_throws_for_zero_Int64() => TestGetValue(DbType.Int64, ValueKind.Zero, x => x.GetByte(0), (byte) 0);
	public override void GetByte_throws_for_zero_Int64_with_GetFieldValue() => TestGetValue(DbType.Int64, ValueKind.Zero, x => x.GetFieldValue<byte>(0), (byte) 0);
	public override void GetByte_throws_for_zero_SByte() => TestGetValue(DbType.SByte, ValueKind.Zero, x => x.GetByte(0), (byte) 0);
	public override void GetByte_throws_for_zero_SByte_with_GetFieldValue() => TestGetValue(DbType.SByte, ValueKind.Zero, x => x.GetFieldValue<byte>(0), (byte) 0);
	public override void GetByte_throws_for_zero_UInt16() => TestGetValue(DbType.UInt16, ValueKind.Zero, x => x.GetByte(0), (byte) 0);
	public override void GetByte_throws_for_zero_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.Zero, x => x.GetFieldValue<byte>(0), (byte) 0);
	public override void GetByte_throws_for_zero_UInt32() => TestGetValue(DbType.UInt32, ValueKind.Zero, x => x.GetByte(0), (byte) 0);
	public override void GetByte_throws_for_zero_UInt32_with_GetFieldValue() => TestGetValue(DbType.UInt32, ValueKind.Zero, x => x.GetFieldValue<byte>(0), (byte) 0);
	public override void GetByte_throws_for_zero_UInt64() => TestGetValue(DbType.UInt64, ValueKind.Zero, x => x.GetByte(0), (byte) 0);
	public override void GetByte_throws_for_zero_UInt64_with_GetFieldValue() => TestGetValue(DbType.UInt64, ValueKind.Zero, x => x.GetFieldValue<byte>(0), (byte) 0);
	public override void GetByte_throws_for_zero_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Zero, x => x.GetByte(0), (byte) 0);
	public override void GetByte_throws_for_zero_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.Zero, x => x.GetFieldValue<byte>(0), (byte) 0);


	// the minimum date permitted by MySQL is 1000-01-01; override the minimum value for DateTime tests
	public override void GetDateTime_for_minimum_Date() => TestGetValue(DbType.Date, ValueKind.Minimum, x => x.GetDateTime(0), new DateTime(1000, 1, 1));
	public override void GetDateTime_for_minimum_Date_with_GetFieldValue() => TestGetValue(DbType.Date, ValueKind.Minimum, x => x.GetFieldValue<DateTime>(0), new DateTime(1000, 1, 1));
	public override void GetDateTime_for_minimum_DateTime() => TestGetValue(DbType.Date, ValueKind.Minimum, x => x.GetDateTime(0), new DateTime(1000, 1, 1));
	public override void GetDateTime_for_minimum_DateTime_with_GetFieldValue() => TestGetValue(DbType.Date, ValueKind.Minimum, x => x.GetFieldValue<DateTime>(0), new DateTime(1000, 1, 1));

	// GetDecimal() allows conversions from float/double
	public override void GetDecimal_throws_for_zero_Single() => TestGetValue(DbType.Single, ValueKind.Zero, x => x.GetDecimal(0), 0m);
	public override void GetDecimal_throws_for_zero_Single_with_GetFieldValue() => TestGetValue(DbType.Single, ValueKind.Zero, x => x.GetFieldValue<decimal>(0), 0m);
	public override void GetDecimal_throws_for_one_Single() => TestGetValue(DbType.Single, ValueKind.One, x => x.GetDecimal(0), 1m);
	public override void GetDecimal_throws_for_one_Single_with_GetFieldValue() => TestGetValue(DbType.Single, ValueKind.One, x => x.GetFieldValue<decimal>(0), 1m);
	public override void GetDecimal_throws_for_minimum_Single() => TestGetValue(DbType.Single, ValueKind.Minimum, x => x.GetDecimal(0), 0m);
	public override void GetDecimal_throws_for_minimum_Single_with_GetFieldValue() => TestGetValue(DbType.Single, ValueKind.Minimum, x => x.GetFieldValue<decimal>(0), 0m);
	public override void GetDecimal_throws_for_maximum_Single() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetDecimal(0), typeof(OverflowException));
	public override void GetDecimal_throws_for_maximum_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetFieldValue<decimal>(0), typeof(OverflowException));
	public override void GetDecimal_throws_for_zero_Double() => TestGetValue(DbType.Double, ValueKind.Zero, x => x.GetDecimal(0), 0m);
	public override void GetDecimal_throws_for_zero_Double_with_GetFieldValue() => TestGetValue(DbType.Double, ValueKind.Zero, x => x.GetFieldValue<decimal>(0), 0m);
	public override void GetDecimal_throws_for_one_Double() => TestGetValue(DbType.Double, ValueKind.One, x => x.GetDecimal(0), 1m);
	public override void GetDecimal_throws_for_one_Double_with_GetFieldValue() => TestGetValue(DbType.Double, ValueKind.One, x => x.GetFieldValue<decimal>(0), 1m);
	public override void GetDecimal_throws_for_minimum_Double() => TestGetValue(DbType.Double, ValueKind.Minimum, x => x.GetDecimal(0), 0m);
	public override void GetDecimal_throws_for_minimum_Double_with_GetFieldValue() => TestGetValue(DbType.Double, ValueKind.Minimum, x => x.GetFieldValue<decimal>(0), 0m);
	public override void GetDecimal_throws_for_maximum_Double() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetDecimal(0), typeof(OverflowException));
	public override void GetDecimal_throws_for_maximum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetFieldValue<decimal>(0), typeof(OverflowException));

	// The GetFloat() implementation allows for conversions from double to float.
	// The minimum tests for float and double do not test for the smallest possible value (as the tests for integer values do),
	// but test for the largest value smaller than 0 (Epsilon).
	// If double.Epsilon is converted to float, it will result in 0.
	public override void GetFloat_throws_for_minimum_Double() => TestGetValue(DbType.Double, ValueKind.Minimum, x => x.GetFloat(0), 0);
	public override void GetFloat_throws_for_minimum_Double_with_GetFieldValue() => TestGetValue(DbType.Double, ValueKind.Minimum, x => x.GetFieldValue<float>(0), 0);
	public override void GetFloat_throws_for_one_Double() => TestGetValue(DbType.Double, ValueKind.One, x => x.GetFloat(0), 1);
	public override void GetFloat_throws_for_one_Double_with_GetFieldValue() => TestGetValue(DbType.Double, ValueKind.One, x => x.GetFieldValue<float>(0), 1);
	public override void GetFloat_throws_for_zero_Double() => TestGetValue(DbType.Double, ValueKind.Zero, x => x.GetFloat(0), 0);
	public override void GetFloat_throws_for_zero_Double_with_GetFieldValue() => TestGetValue(DbType.Double, ValueKind.Zero, x => x.GetFieldValue<float>(0), 0);
}
