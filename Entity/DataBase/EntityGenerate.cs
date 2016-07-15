﻿
//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by template for T4.
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;

using SmiteRepository;

namespace TaskManager.Entity
{

	[TableName("ts_ExecLog")]
	public partial class Ts_ExecLog : BaseEntity
	{
		private int _Id;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>
		[Identity, PrimaryKey(1)] 
		public int Id
		{ get{ return _Id; } 	set{ _Id = value ;  OnPropertyChanged("Id"); } }
		private string _TaskGuid;
		/// <summary>
		/// 
		///  varchar(36)
		/// </summary>

		public string TaskGuid
		{ get{ return _TaskGuid; } 	set{ _TaskGuid = value ;  OnPropertyChanged("TaskGuid"); } }
		private DateTime _ExecStatrtTime;
		/// <summary>
		/// 
		///  datetime(3)
		/// </summary>

		public DateTime ExecStatrtTime
		{ get{ return _ExecStatrtTime; } 	set{ _ExecStatrtTime = value ;  OnPropertyChanged("ExecStatrtTime"); } }
		private DateTime _ExecEndTime;
		/// <summary>
		/// 
		///  datetime(3)
		/// </summary>

		public DateTime ExecEndTime
		{ get{ return _ExecEndTime; } 	set{ _ExecEndTime = value ;  OnPropertyChanged("ExecEndTime"); } }
		private string _ExecResult;
		/// <summary>
		/// 
		///  varchar(-1)
		/// </summary>

		public string ExecResult
		{ get{ return _ExecResult; } 	set{ _ExecResult = value ;  OnPropertyChanged("ExecResult"); } }
		private int _ExecResultCode;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>

		public int ExecResultCode
		{ get{ return _ExecResultCode; } 	set{ _ExecResultCode = value ;  OnPropertyChanged("ExecResultCode"); } }
		private string _ExecUrl;
		/// <summary>
		/// 
		///  varchar(200)
		/// </summary>

		public string ExecUrl
		{ get{ return _ExecUrl; } 	set{ _ExecUrl = value ;  OnPropertyChanged("ExecUrl"); } }
		private string _ExecParams;
		/// <summary>
		/// 
		///  varchar(200)
		/// </summary>
		[Nullable  ] 
		public string ExecParams
		{ get{ return _ExecParams; } 	set{ _ExecParams = value ;  OnPropertyChanged("ExecParams"); } }
	}

	[TableName("ts_ExecLog_201607")]
	public partial class Ts_ExecLog_201607 : BaseEntity
	{
		private int _Id;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>
		[Identity, PrimaryKey(1)] 
		public int Id
		{ get{ return _Id; } 	set{ _Id = value ;  OnPropertyChanged("Id"); } }
		private string _TaskGuid;
		/// <summary>
		/// 
		///  varchar(36)
		/// </summary>

		public string TaskGuid
		{ get{ return _TaskGuid; } 	set{ _TaskGuid = value ;  OnPropertyChanged("TaskGuid"); } }
		private DateTime _ExecStatrtTime;
		/// <summary>
		/// 
		///  datetime(3)
		/// </summary>

		public DateTime ExecStatrtTime
		{ get{ return _ExecStatrtTime; } 	set{ _ExecStatrtTime = value ;  OnPropertyChanged("ExecStatrtTime"); } }
		private DateTime _ExecEndTime;
		/// <summary>
		/// 
		///  datetime(3)
		/// </summary>

		public DateTime ExecEndTime
		{ get{ return _ExecEndTime; } 	set{ _ExecEndTime = value ;  OnPropertyChanged("ExecEndTime"); } }
		private string _ExecResult;
		/// <summary>
		/// 
		///  varchar(-1)
		/// </summary>

		public string ExecResult
		{ get{ return _ExecResult; } 	set{ _ExecResult = value ;  OnPropertyChanged("ExecResult"); } }
		private int _ExecResultCode;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>

		public int ExecResultCode
		{ get{ return _ExecResultCode; } 	set{ _ExecResultCode = value ;  OnPropertyChanged("ExecResultCode"); } }
		private string _ExecUrl;
		/// <summary>
		/// 
		///  varchar(200)
		/// </summary>

		public string ExecUrl
		{ get{ return _ExecUrl; } 	set{ _ExecUrl = value ;  OnPropertyChanged("ExecUrl"); } }
		private string _ExecParams;
		/// <summary>
		/// 
		///  varchar(200)
		/// </summary>
		[Nullable  ] 
		public string ExecParams
		{ get{ return _ExecParams; } 	set{ _ExecParams = value ;  OnPropertyChanged("ExecParams"); } }
	}

	[TableName("ts_Servers")]
	public partial class Ts_Servers : BaseEntity
	{
		private int _Id;
		/// <summary>
		/// ID
		///  int(10)
		/// </summary>
		[Identity, PrimaryKey(1)] 
		public int Id
		{ get{ return _Id; } 	set{ _Id = value ;  OnPropertyChanged("Id"); } }
		private string _ServerName;
		/// <summary>
		/// 
		///  varchar(50)
		/// </summary>

		public string ServerName
		{ get{ return _ServerName; } 	set{ _ServerName = value ;  OnPropertyChanged("ServerName"); } }
		private DateTime _LastHeartTime;
		/// <summary>
		/// 
		///  datetime(3)
		/// </summary>

		public DateTime LastHeartTime
		{ get{ return _LastHeartTime; } 	set{ _LastHeartTime = value ;  OnPropertyChanged("LastHeartTime"); } }
		private bool _IsEnable;
		/// <summary>
		/// 
		///  bit
		/// </summary>

		public bool IsEnable
		{ get{ return _IsEnable; } 	set{ _IsEnable = value ;  OnPropertyChanged("IsEnable"); } }
		private string _ServerIP;
		/// <summary>
		/// 
		///  varchar(200)
		/// </summary>
		[Nullable  ] 
		public string ServerIP
		{ get{ return _ServerIP; } 	set{ _ServerIP = value ;  OnPropertyChanged("ServerIP"); } }
		private bool _IsMain;
		/// <summary>
		/// 
		///  bit
		/// </summary>

		public bool IsMain
		{ get{ return _IsMain; } 	set{ _IsMain = value ;  OnPropertyChanged("IsMain"); } }
	}

	[TableName("ts_TaskExec")]
	public partial class Ts_TaskExec : BaseEntity
	{
		private string _TaskGuid;
		/// <summary>
		/// 
		///  varchar(36)
		/// </summary>
		[  PrimaryKey(1)] 
		public string TaskGuid
		{ get{ return _TaskGuid; } 	set{ _TaskGuid = value ;  OnPropertyChanged("TaskGuid"); } }
		private DateTime? _LastExecTime;
		/// <summary>
		/// 
		///  datetime(3)
		/// </summary>
		[Nullable  ] 
		public DateTime? LastExecTime
		{ get{ return _LastExecTime; } 	set{ _LastExecTime = value ;  OnPropertyChanged("LastExecTime"); } }
		private int? _LastExecId;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>
		[Nullable  ] 
		public int? LastExecId
		{ get{ return _LastExecId; } 	set{ _LastExecId = value ;  OnPropertyChanged("LastExecId"); } }
		private int? _LastExecResultCode;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>
		[Nullable  ] 
		public int? LastExecResultCode
		{ get{ return _LastExecResultCode; } 	set{ _LastExecResultCode = value ;  OnPropertyChanged("LastExecResultCode"); } }
	}

	[TableName("ts_Tasks")]
	public partial class Ts_Tasks : BaseEntity
	{
		private string _Guid;
		/// <summary>
		/// 
		///  varchar(36)
		/// </summary>
		[  PrimaryKey(1)] 
		public string Guid
		{ get{ return _Guid; } 	set{ _Guid = value ;  OnPropertyChanged("Guid"); } }
		private int _CreateUser;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>

		public int CreateUser
		{ get{ return _CreateUser; } 	set{ _CreateUser = value ;  OnPropertyChanged("CreateUser"); } }
		private string _Title;
		/// <summary>
		/// 
		///  nvarchar(50)
		/// </summary>

		public string Title
		{ get{ return _Title; } 	set{ _Title = value ;  OnPropertyChanged("Title"); } }
		private string _ExecUrl;
		/// <summary>
		/// 
		///  varchar(200)
		/// </summary>

		public string ExecUrl
		{ get{ return _ExecUrl; } 	set{ _ExecUrl = value ;  OnPropertyChanged("ExecUrl"); } }
		private int _ExecType;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>

		public int ExecType
		{ get{ return _ExecType; } 	set{ _ExecType = value ;  OnPropertyChanged("ExecType"); } }
		private int _Interval;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>

		public int Interval
		{ get{ return _Interval; } 	set{ _Interval = value ;  OnPropertyChanged("Interval"); } }
		private DateTime _InsertTime;
		/// <summary>
		/// 
		///  datetime(3)
		/// </summary>

		public DateTime InsertTime
		{ get{ return _InsertTime; } 	set{ _InsertTime = value ;  OnPropertyChanged("InsertTime"); } }
		private int _Status;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>

		public int Status
		{ get{ return _Status; } 	set{ _Status = value ;  OnPropertyChanged("Status"); } }
		private bool _IsResponseNorm;
		/// <summary>
		/// 
		///  bit
		/// </summary>

		public bool IsResponseNorm
		{ get{ return _IsResponseNorm; } 	set{ _IsResponseNorm = value ;  OnPropertyChanged("IsResponseNorm"); } }
		private string _ExecMethod;
		/// <summary>
		/// 
		///  varchar(10)
		/// </summary>
		[Nullable  ] 
		public string ExecMethod
		{ get{ return _ExecMethod; } 	set{ _ExecMethod = value ;  OnPropertyChanged("ExecMethod"); } }
		private int _TimeOut;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>

		public int TimeOut
		{ get{ return _TimeOut; } 	set{ _TimeOut = value ;  OnPropertyChanged("TimeOut"); } }
		private bool _IsLogResult;
		/// <summary>
		/// 
		///  bit
		/// </summary>

		public bool IsLogResult
		{ get{ return _IsLogResult; } 	set{ _IsLogResult = value ;  OnPropertyChanged("IsLogResult"); } }
		private string _Encoding;
		/// <summary>
		/// 
		///  varchar(50)
		/// </summary>
		[Nullable  ] 
		public string Encoding
		{ get{ return _Encoding; } 	set{ _Encoding = value ;  OnPropertyChanged("Encoding"); } }
		private string _ExecParams;
		/// <summary>
		/// 
		///  varchar(200)
		/// </summary>
		[Nullable  ] 
		public string ExecParams
		{ get{ return _ExecParams; } 	set{ _ExecParams = value ;  OnPropertyChanged("ExecParams"); } }
		private bool _IsErrorAlert;
		/// <summary>
		/// 
		///  bit
		/// </summary>

		public bool IsErrorAlert
		{ get{ return _IsErrorAlert; } 	set{ _IsErrorAlert = value ;  OnPropertyChanged("IsErrorAlert"); } }
		private string _ReceiveEmail;
		/// <summary>
		/// 
		///  varchar(200)
		/// </summary>
		[Nullable  ] 
		public string ReceiveEmail
		{ get{ return _ReceiveEmail; } 	set{ _ReceiveEmail = value ;  OnPropertyChanged("ReceiveEmail"); } }
		private int _RunServerId;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>

		public int RunServerId
		{ get{ return _RunServerId; } 	set{ _RunServerId = value ;  OnPropertyChanged("RunServerId"); } }
	}

	[TableName("tu_Users")]
	public partial class Tu_Users : BaseEntity
	{
		private int _UserId;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>
		[Identity, PrimaryKey(1)] 
		public int UserId
		{ get{ return _UserId; } 	set{ _UserId = value ;  OnPropertyChanged("UserId"); } }
		private string _UserName;
		/// <summary>
		/// 
		///  varchar(50)
		/// </summary>

		public string UserName
		{ get{ return _UserName; } 	set{ _UserName = value ;  OnPropertyChanged("UserName"); } }
		private string _PassWord;
		/// <summary>
		/// 
		///  varchar(50)
		/// </summary>

		public string PassWord
		{ get{ return _PassWord; } 	set{ _PassWord = value ;  OnPropertyChanged("PassWord"); } }
		private DateTime _InsertTime;
		/// <summary>
		/// 
		///  datetime(3)
		/// </summary>

		public DateTime InsertTime
		{ get{ return _InsertTime; } 	set{ _InsertTime = value ;  OnPropertyChanged("InsertTime"); } }
		private string _RealName;
		/// <summary>
		/// 
		///  varchar(50)
		/// </summary>

		public string RealName
		{ get{ return _RealName; } 	set{ _RealName = value ;  OnPropertyChanged("RealName"); } }
		private int _Status;
		/// <summary>
		/// 
		///  int(10)
		/// </summary>

		public int Status
		{ get{ return _Status; } 	set{ _Status = value ;  OnPropertyChanged("Status"); } }
	}
}
