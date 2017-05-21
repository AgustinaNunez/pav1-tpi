Public Class SoporteGUI
    Public Enum tipo_form
        abm
        transaccion
    End Enum
    Public Shared tipo_form_ACTUAL As tipo_form = tipo_form.abm

    'SUBRUTINA QUE CARGA UN COMBO
    Public Shared Sub cargar_combo(ByRef combo As ComboBox, tabla As DataTable,
                                   ByVal pk As String, ByVal descriptor As String)
        combo.DataSource = tabla
        combo.DisplayMember = descriptor
        combo.ValueMember = pk
    End Sub

    Public Shared flag As Boolean = False

End Class
