//------------------------------------------------------------------------------
// File   : CfgData.cs
// Author : Saro
// Time   : 2020/5/29 0:50:19
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace tabtool
{
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    
    
    public class DbTest
    {
        
        /// <summary>
        /// int
        /// </summary>
        public int _int;
        
        /// <summary>
        /// byte
        /// </summary>
        public byte _byte;
        
        /// <summary>
        /// long
        /// </summary>
        public long _long;
        
        /// <summary>
        /// float
        /// </summary>
        public float _float;
        
        /// <summary>
        /// string
        /// </summary>
        public string _string;
        
        /// <summary>
        /// byte+
        /// </summary>
        public System.Collections.Generic.List<byte> byte_arr;
        
        /// <summary>
        /// int+
        /// </summary>
        public System.Collections.Generic.List<int> int_arr;
        
        /// <summary>
        /// long+
        /// </summary>
        public System.Collections.Generic.List<long> long_arr;
        
        /// <summary>
        /// float+
        /// </summary>
        public System.Collections.Generic.List<float> float_arr;
    }
    
    public class CfgTest : TableBase<DbTest, CfgTest>
    {
        
        public override bool Load()
        {
			var bytes = GetBytes("Test.txt");

			using (var ms = new MemoryStream(bytes))
			{
				using (var br = new BinaryReader(ms))
				{
					var version = br.ReadInt32();//version
					var dataLen = br.ReadInt32();
					for (int i = 0; i < dataLen; i++)
					{
						var data = new DbTest();
						data._int = br.ReadInt32();
						data._byte = br.ReadByte();
						data._long = br.ReadInt64();
						data._float = br.ReadSingle();
						data._string = br.ReadString();
						var len = br.ReadUInt16();
						data.byte_arr = new List<byte>(len);
						for (int j = 0; j < len; j++)
						{
							data.byte_arr.Add(br.ReadByte());
						}
						len = br.ReadUInt16();
						data.int_arr = new List<int>(len);
						for (int j = 0; j < len; j++)
						{
							data.int_arr.Add(br.ReadInt32());
						}
						len = br.ReadUInt16();
						data.long_arr = new List<long>(len);
						for (int j = 0; j < len; j++)
						{
							data.long_arr.Add(br.ReadInt64());
						}
						len = br.ReadUInt16();
						data.float_arr = new List<float>(len);
						for (int j = 0; j < len; j++)
						{
							data.float_arr.Add(br.ReadSingle());
						}
						m_Datas[data._int] = data;
					}
				}
			}

            return true;
        }
        
        public override string ToString()
        {
			var sb = new StringBuilder(1024);
			foreach (var data in m_Datas.Values)
			{
				sb.Append(data._int).Append("\t");
				sb.Append(data._byte).Append("\t");
				sb.Append(data._long).Append("\t");
				sb.Append(data._float).Append("\t");
				sb.Append(data._string).Append("\t");
				sb.Append(string.Join(",", data.byte_arr)).Append("\t");
				sb.Append(string.Join(",", data.int_arr)).Append("\t");
				sb.Append(string.Join(",", data.long_arr)).Append("\t");
				sb.Append(string.Join(",", data.float_arr)).Append("\t");
				sb.AppendLine();
			}

            return sb.ToString();
        }
    }
    
    public enum EIDTest
    {
        
        key1 = 0,
        
        key2 = 2,
        
        key3 = 3,
        
        key4 = 4,
        
        key5 = 5,
        
        key6 = 6,
        
        key7 = 7,
        
        key8 = 8,
        
        key9 = 9,
        
        key10 = 10,
        
        key11 = 11,
        
        key12 = 12,
        
        key13 = 13,
        
        key14 = 14,
        
        key15 = 15,
        
        key16 = 16,
        
        key17 = 17,
        
        key18 = 18,
        
        key19 = 19,
    }
    
    public class DbITEM
    {
        
        /// <summary>
        /// key
        /// </summary>
        public int id;
        
        /// <summary>
        /// 描述
        /// </summary>
        public string name;
        
        /// <summary>
        /// bbb
        /// </summary>
        public System.Collections.Generic.List<long> long_list;
    }
    
    public class CfgITEM : TableBase<DbITEM, CfgITEM>
    {
        
        public override bool Load()
        {
			var bytes = GetBytes("ITEM.txt");

			using (var ms = new MemoryStream(bytes))
			{
				using (var br = new BinaryReader(ms))
				{
					var version = br.ReadInt32();//version
					var dataLen = br.ReadInt32();
					for (int i = 0; i < dataLen; i++)
					{
						var data = new DbITEM();
						data.id = br.ReadInt32();
						data.name = br.ReadString();
						var len = br.ReadUInt16();
						data.long_list = new List<long>(len);
						for (int j = 0; j < len; j++)
						{
							data.long_list.Add(br.ReadInt64());
						}
						m_Datas[data.id] = data;
					}
				}
			}

            return true;
        }
        
        public override string ToString()
        {
			var sb = new StringBuilder(1024);
			foreach (var data in m_Datas.Values)
			{
				sb.Append(data.id).Append("\t");
				sb.Append(data.name).Append("\t");
				sb.Append(string.Join(",", data.long_list)).Append("\t");
				sb.AppendLine();
			}

            return sb.ToString();
        }
    }
    
    public enum EIDITEM
    {
        
        a = 1,
        
        b = 2,
        
        c = 3,
        
        d = 4,
        
        e = 5,
        
        f = 6,
        
        g = 7,
        
        h = 8,
        
        i = 9,
    }
}