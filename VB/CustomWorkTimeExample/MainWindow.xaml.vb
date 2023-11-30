Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Windows

Namespace CustomWorkTimeExample

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub SchedulerControl_CustomWorkTime(ByVal sender As Object, ByVal e As DevExpress.Xpf.Scheduling.CustomWorkTimeEventArgs)
            If e.Resource.Id.Equals("1") Then
                If e.Interval.Start.Day Mod 2 = 0 Then
                    Dim workTimes As List(Of TimeSpanRange) = New List(Of TimeSpanRange) From {New TimeSpanRange(TimeSpan.FromHours(0), TimeSpan.FromHours(3)), New TimeSpanRange(TimeSpan.FromHours(5), TimeSpan.FromHours(8)), New TimeSpanRange(TimeSpan.FromHours(10), TimeSpan.FromHours(11))}
                    e.WorkTimes = workTimes
                Else
                    e.WorkTime = New TimeSpanRange(TimeSpan.FromHours(8), TimeSpan.FromHours(20))
                End If
            End If

            If e.Resource.Id.Equals("2") Then
                If e.Interval.Start.Day Mod 2 = 0 Then
                    e.WorkTime = New TimeSpanRange(TimeSpan.FromHours(14), TimeSpan.FromHours(18))
                Else
                    e.WorkTime = New TimeSpanRange(TimeSpan.FromHours(8), TimeSpan.FromHours(12))
                End If
            End If

            If e.Resource.Id.Equals("3") Then e.WorkTime = New TimeSpanRange(TimeSpan.FromHours(14), TimeSpan.FromHours(21))
            If e.Resource.Id.Equals("4") Then
                Dim workTimes As List(Of TimeSpanRange) = New List(Of TimeSpanRange) From {New TimeSpanRange(TimeSpan.FromHours(8), TimeSpan.FromHours(11)), New TimeSpanRange(TimeSpan.FromHours(13), TimeSpan.FromHours(17))}
                e.WorkTimes = workTimes
            End If
        End Sub
    End Class
End Namespace
