Public Class Form1
    Private Const CSS_RATE As Double = 0.0975
    Private Const FSE_RATE As Double = 0.0125
    Private Const HOURS_IN_MONTH As Double = 240.0

    Private Sub txtacepta_Click(sender As Object, e As EventArgs) Handles txtacepta.Click
        Dim baseSalary As Double
        Dim extraHours As Double
        Dim hourValue As Double
        Dim extraRecargo As Double = 0.0 ' Multiplicador
        Dim totalExtraPay As Double = 0.0
        Dim totalDiscounts As Double
        Dim netSalary As Double

        ' 1. Validar y obtener inputs (si no es número o está vacío, salimos)
        If Not Double.TryParse(txtbase.Text, baseSalary) Or baseSalary <= 0 Then
            MessageBox.Show("Pon un Salario Base válido, ¡por favor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtbase.Focus()
            Exit Sub
        End If

        Double.TryParse(txtExtras.Text, extraHours) ' No importa si está vacío, es 0.

        ' 2. Definir el recargo de horas extras
        If txtTomorrow.Checked Then
            extraRecargo = 1.25 ' Diurna (25% extra)

        ElseIf txttard.Checked Then
            extraRecargo = 1.5 ' Nocturna/Mixta (50% extra)
        Else
            MessageBox.Show("Debes marcar la jornada (Diurna o Nocturna) para el cálculo de horas extras.", "Falta Dato", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 3. CALCULAR EXTRAS
        hourValue = baseSalary / HOURS_IN_MONTH

        ' Pago Total Extras = Horas Extras * (Valor Hora Regular * Recargo)
        totalExtraPay = extraHours * (hourValue * extraRecargo)

        ' Mostrar Pago de Extras inmediatamente
        txtPagoporhora.Text = totalExtraPay.ToString("C")

        ' 4. CALCULAR DESCUENTOS (CSS + FSE)
        Dim cssDiscount As Double = baseSalary * CSS_RATE
        Dim fseDiscount As Double = baseSalary * FSE_RATE
        totalDiscounts = cssDiscount + fseDiscount

        ' Mostrar descuentos
        txtsegur.Text = cssDiscount.ToString("C")
        txtsegurodevida.Text = fseDiscount.ToString("C")

        ' 5. CALCULAR SALARIO NETO
        ' SalarioNeto = Base + Extras - Descuentos
        netSalary = baseSalary + totalExtraPay - totalDiscounts

        ' Mostrar el resultado final
        txtsueldoneto.Text = netSalary.ToString("C")
    End Sub

    Private Sub txtBorrar_Click(sender As Object, e As EventArgs) Handles txtBorrar.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Checked = False
            End If
        Next
        txtbase.Focus()
    End Sub

    Private Sub txtsal_Click(sender As Object, e As EventArgs) Handles txtsal.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtsegur.Enabled = False
        txtsueldoneto.Enabled = False
        txtsegurodevida.Enabled = False
        txtPagoporhora.Enabled = False
    End Sub
End Class
