// --- auto-generated code --- do not modify ---
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Skyline.DataMiner.Scripting
{
public static class Parameter
{
	/// <summary>PID: 10 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int currenttimeutc_10 = 10;
	/// <summary>PID: 10 | Type: read</summary>
	public const int currenttimeutc = 10;
	/// <summary>PID: 11 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int timer_11 = 11;
	/// <summary>PID: 11 | Type: read</summary>
	public const int timer = 11;
	/// <summary>PID: 12 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int timerstatus_12 = 12;
	/// <summary>PID: 12 | Type: read</summary>
	public const int timerstatus = 12;
	public class Write
	{
		/// <summary>PID: 15 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int but_timeractions_15 = 15;
		/// <summary>PID: 15 | Type: write</summary>
		public const int but_timeractions = 15;
	}
}
public class WriteParameters
{
	/// <summary>PID: 15  | Type: write | DISCREETS: Start Timer = 0, Stop Timer = 1, Reset Timer = 2</summary>
	public System.Object But_timeractions {get { return Protocol.GetParameter(15); }set { Protocol.SetParameter(15, value); }}
	public SLProtocolExt Protocol;
	public WriteParameters(SLProtocolExt protocol)
	{
		Protocol = protocol;
	}
}
public interface SLProtocolExt : SLProtocol
{
	object Updateutctime_dummy { get; set; }
	object Currenttimeutc_10 { get; set; }
	object Currenttimeutc { get; set; }
	object Timer_11 { get; set; }
	object Timer { get; set; }
	object Timerstatus_12 { get; set; }
	object Timerstatus { get; set; }
	object But_timeractions_15 { get; set; }
	object But_timeractions { get; set; }
	WriteParameters Write { get; set; }
}
public class ConcreteSLProtocolExt : ConcreteSLProtocol, SLProtocolExt
{
	/// <summary>PID: 9  | Type: dummy</summary>
	public System.Object Updateutctime_dummy {get { return GetParameter(9); }set { SetParameter(9, value); }}
	/// <summary>PID: 10  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Currenttimeutc_10 {get { return GetParameter(10); }set { SetParameter(10, value); }}
	/// <summary>PID: 10  | Type: read</summary>
	public System.Object Currenttimeutc {get { return GetParameter(10); }set { SetParameter(10, value); }}
	/// <summary>PID: 11  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Timer_11 {get { return GetParameter(11); }set { SetParameter(11, value); }}
	/// <summary>PID: 11  | Type: read</summary>
	public System.Object Timer {get { return GetParameter(11); }set { SetParameter(11, value); }}
	/// <summary>PID: 12  | Type: read | DISCREETS: Stopped = 0, Running = 1</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Timerstatus_12 {get { return GetParameter(12); }set { SetParameter(12, value); }}
	/// <summary>PID: 12  | Type: read | DISCREETS: Stopped = 0, Running = 1</summary>
	public System.Object Timerstatus {get { return GetParameter(12); }set { SetParameter(12, value); }}
	/// <summary>PID: 15  | Type: write | DISCREETS: Start Timer = 0, Stop Timer = 1, Reset Timer = 2</summary>
	public System.Object But_timeractions_15 {get { return GetParameter(15); }set { SetParameter(15, value); }}
	/// <summary>PID: 15  | Type: write | DISCREETS: Start Timer = 0, Stop Timer = 1, Reset Timer = 2</summary>
	public System.Object But_timeractions {get { return Write.But_timeractions; }set { Write.But_timeractions = value; }}
	public WriteParameters Write { get; set; }
	public ConcreteSLProtocolExt()
	{
		Write = new WriteParameters(this);
	}
}
}
