using System;
using Skyline.DataMiner.Scripting;

internal enum TimerActions
{
	Start,
	Stop,
	Reset,
}

/// <summary>
/// DataMiner QAction Class: TimerActions.
/// </summary>
public static class QAction
{
	/// <summary>
	/// The QAction entry point.
	/// </summary>
	/// <param name="protocol">Link with SLProtocol process.</param>
	public static void Run(SLProtocol protocol)
	{
		try
		{
			var rawTriggerValue = Convert.ToInt32(protocol.GetParameter(protocol.GetTriggerParameter()));
			var triggerValue = (TimerActions)Enum.ToObject(typeof(TimerActions), rawTriggerValue);

			switch (triggerValue)
			{
				case TimerActions.Start:
					protocol.SetParameter(Parameter.timerstatus_12, 1);
					break;

				case TimerActions.Stop:
					protocol.SetParameter(Parameter.timerstatus_12, 0);
					break;

				case TimerActions.Reset:
					protocol.SetParameter(Parameter.timer_11, 0);
					break;

				default:
					throw new InvalidOperationException("Trigger value not implemented.");
			}
		}
		catch (Exception ex)
		{
			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
		}
	}
}