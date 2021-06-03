Module ModMsg

    Public Sub MsgInformacion(Msg As String)
        MessageBox.Show(Msg, "Mi Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub MsgError(Msg As String)
        MessageBox.Show(Msg, "Mi Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub MsgWarning(Msg As String)
        MessageBox.Show(Msg, "Mi Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Function MsgPregunta(Msg As String) As DialogResult
        Return MessageBox.Show(Msg, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Function


End Module
