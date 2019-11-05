Option Strict On
Option Explicit On
Option Compare Binary

Imports OGU98Common_Client.bas98C02_Function
Imports OGU99Common.bas99C02_Function

Public Class SpeedTester

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Me.Cursor = Cursors.WaitCursor
        Dim dtbl As DataTable = Nothing
        Dim dtblResult As DataTable = Nothing
        Dim booRet As Boolean = True
        Dim booTmpRet As Boolean = False
        Dim intCount As Integer = 0
        Dim strStartTime As String = String.Empty
        Dim strEndTime As String = String.Empty

        Try
            '入力チェック
            If txtSQL.TextLength = 0 Then
                MsgBox("SQLを記入してください")
                txtSQL.Focus()
            End If
            If Not Integer.TryParse(txtCount.Text, intCount) Then
                MsgBox("SQLを記入してください")
                txtCount.Focus()
            End If

            '結果データテーブルの作成
            dtblResult = New DataTable
            dtblResult.Columns.Add("START")
            dtblResult.Columns.Add("END")

            'WebSV実行
            For i As Integer = 1 To intCount
                strStartTime = fncGetTime()
                booTmpRet = gfncDBReadSQL(txtSQL.Text, dtbl)
                strEndTime = fncGetTime()
                dtblResult.Rows.Add(strStartTime, strEndTime)
                booRet = booRet And booTmpRet
            Next

            If booRet Then
                'DGVの描画
                With dgvResult
                    .Rows.Clear()
                    .RowCount = dtblResult.Rows.Count
                    For i As Integer = 0 To dtblResult.Rows.Count - 1
                        .Item("seq", i).Value = (i + 1).ToString
                        .Item("starttime", i).Value = gfncNullToStr(dtblResult.Rows(i)("START"))
                        .Item("endtime", i).Value = gfncNullToStr(dtblResult.Rows(i)("END"))
                        .Item("ms", i).Value = fncCalc(gfncNullToStr(dtblResult.Rows(i)("START")),
                                                       gfncNullToStr(dtblResult.Rows(i)("END")))
                    Next
                End With
            Else
                MsgBox("SQL実行失敗しました")
            End If

        Catch ex As Exception
            MsgBox("Error")

        Finally
            If Not IsNothing(dtbl) Then
                dtbl.Dispose()
            End If
            If Not IsNothing(dtblResult) Then
                dtblResult.Dispose()
            End If
            Me.Cursor = Cursors.Default

        End Try

    End Sub

    Private Function fncGetTime() As String

        fncGetTime = String.Empty
        Dim dtmNow As DateTime = DateTime.Now
        fncGetTime = dtmNow.ToString("HH:mm:ss") & ":" & dtmNow.Millisecond.ToString.PadLeft(3, "0"c)

    End Function

    Private Function fncCalc(ByVal pstrStart As String,
                             ByVal pstrEnd As String) As String

        fncCalc = String.Empty

        Dim arrstrStart As String() = pstrStart.Split(":"c)
        Dim arrstrEnd As String() = pstrEnd.Split(":"c)

        If arrstrStart.Length = 4 AndAlso arrstrEnd.Length = 4 Then
            Dim tsStrat As New TimeSpan(0,
                                        CInt(arrstrStart(0)),
                                        CInt(arrstrStart(1)),
                                        CInt(arrstrStart(2)),
                                        CInt(arrstrStart(3)))
            Dim tsEnd As New TimeSpan(0,
                                        CInt(arrstrEnd(0)),
                                        CInt(arrstrEnd(1)),
                                        CInt(arrstrEnd(2)),
                                        CInt(arrstrEnd(3)))
            Dim tsResult As TimeSpan = tsEnd - tsStrat
            fncCalc = tsResult.TotalSeconds.ToString

        End If

    End Function

End Class
