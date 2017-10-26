Option Strict Off
Option Explicit On
Imports System
Imports System.IO.Ports
Imports System.Globalization
Imports VB = Microsoft.VisualBasic

Module ControlledInfuser

  Public TestWithoutPump As Boolean = False
  Public TestPresetVAS As Boolean = False
  Public FastSimulation As Boolean = False
  Public RateScale As Double = 1 '0.30466 '?0.3567=(8.66)^2/(14.50)^2
  Public ScanTime As Double = 1200 ' seconds
  Public BolusInjectionVolume As Double
  Public RampDuration As Double
  Public BolusInfusionRate As Double
  Public InfusionTimes(300) As Double
  Public InfusionRates(300) As Double
  Public CurrentTime As Double
  Public BaudRate As Double
  Public Response As String
  Public PainFileName As String
  Public InjectingFlag As Boolean
  Public SubjGender As Boolean
  Public ThisDate As Date
  Public VASSetPoint As Short = 40
  Public SubjID As String = "S" & Left(Today.ToString("s"), 10)
  Public ScanID As String
  Public MaxInfuRate As Short = 250
  Public com1 As IO.Ports.SerialPort
  Public DestDir As String = "C:\Temp"

  Public Sub StartInjection()
    If TestWithoutPump = False Then
      SendToComm("RUN")
    End If
  End Sub

  Public Sub EndInjection()
    InjectingFlag = False
    If TestWithoutPump = False Then
      SendToComm("STP")
      Response = SendToComm("KEY")
    End If
  End Sub

    Public Sub InitCommSP(portName)
        Dim pumpver As String
        pumpver = ""
        com1 = My.Computer.Ports.OpenSerialPort(portName)
        com1.BaudRate = 9600
        com1.Parity = Parity.None
        com1.DataBits = 8
        com1.StopBits = 2
    End Sub


    Public Function SendToComm(ByVal ComStr As String) As String

    Dim SS, PP As String 'Object
    Dim t0 As Double 'Object
    Dim t1 As Double 'Object
    Console.WriteLine(ComStr)
    com1.WriteLine(ComStr & Chr(13))
    SS = ""
    PP = ""
    SendToComm = ""
    t0 = VB.Timer()
    Do

      SS = SS & Chr(com1.ReadChar()) 'ReadLine()
      PP = Right(SS, 1)
      System.Windows.Forms.Application.DoEvents()
      t1 = VB.Timer()
      If (t1 - t0) > 60 Then
        SendToComm = "TimeOut"
        Exit Function
      End If
    Loop While PP <> ":" And PP <> ">" And PP <> "<" And PP <> "*"
        If Len(SS) > 3 Then
            SendToComm = Mid(SS, 3, InStr(3, SS, Chr(13)) - 3)
        End If
        SS = BlankCRLF(SS)
    End Function

  Public Function BlankCRLF(ByVal SS As String) As String
    Dim CRstr As New VB6.FixedLengthString(1)
    Dim LFstr As New VB6.FixedLengthString(1)
    Dim SpaceStr As New VB6.FixedLengthString(1)
    Dim TempStr As String

    CRstr.Value = Chr(13)
    SpaceStr.Value = " "
    TempStr = Find_Replace(SS, CRstr.Value, SpaceStr.Value, 0)
    LFstr.Value = Chr(10)
    BlankCRLF = Find_Replace(TempStr, LFstr.Value, SpaceStr.Value, 0)

  End Function

  Public Function Find_Replace(ByVal srchString As String, ByVal FndString As String, ByVal InsertString As String, ByVal strEnd As Short) As String

    Dim LastChar, Next_Pos As Short

    Dim TempString As String

    If strEnd > 0 Then
      LastChar = strEnd
    Else
      LastChar = Len(srchString)
    End If

    TempString = srchString
    Next_Pos = 0
    Next_Pos = InStr(Next_Pos + 1, TempString, FndString)
    Do Until (Next_Pos = 0) Or (Next_Pos > LastChar)
      TempString = Left(TempString, Next_Pos - 1) & InsertString & Right(TempString, Len(TempString) - Len(FndString) - (Next_Pos - 1))
      LastChar = LastChar - Len(FndString) + Len(InsertString)
      Next_Pos = 0
      Next_Pos = InStr(Next_Pos + 1, TempString, FndString)
    Loop
    Find_Replace = TempString

  End Function

End Module