3. 
Form”FormConsulaAdvogado”, consulaAdvogadoErrorProvider para validar o registo ao gravar.

2.1 A data da consulta não pode ser superior a 15 dias atras.
2.2 A duração em minutos tem de estar no intervalo [15-120] minutos.
2.3 A idade não pode ser negativa.
2.4 O código não pode ser vazio.


private bool ValoresValidos(bool soChave)
        {
            bool ok = false;
            this.consultaAdvogadoErrorProvider.Clear();

            string codigoConsultaAdvogado = consultaAdvogadoTextBox.Text;
            DateTime dataConsulta = this.dataInicioDateTimePicker.Value;
            int idadeCliente = 0;
            int duracaoConsultaMinutos = 0;

            //[2.4]
            if (string.IsNullOrWhiteSpace(this.consultaAdvogadoTextBox.Text))
            {
                this.consultaAdvogadoErrorProvider.SetError(this.consultaAdvogadoTextBox,
                                                 "Registo invalido");
                this.consultaAdvogadoTextBox.Focus();
            }
            //[2.3]
            else if (!soChave && !int.TryParse(this.idadeClienteTextBox.Text,
                              out idadeCliente))
            {
                this.consultaAdvogadoErrorProvider.SetError(this.idadeClienteTextBox,
                                                 "Registo invalido");
                this.idadeClienteTextBox.Focus();
            }
            //[2.3]
            else if (!soChave && idadeCliente < 0)
            {
                this.consultaAdvogadoErrorProvider.SetError(this.idadeClienteTextBox,
                                                 "Valor negativo");
                this.idadeClienteTextBox.Focus();
            }
            //[2.1]
            else if (!soChave && dataConsulta > DateTime.Today.AddDays(-15))
            {
                this.consultaAdvogadoErrorProvider.SetError(this.dataInicioDateTimePicker,
                                                 "Data tem de ser inferior a 15 atras");
                this.dataInicioDateTimePicker.Focus();
            }
            //[2.2] v1 e v2
            else if (!soChave && !int.TryParse(this.duracaoConsultaMinutostextBox.Text,
                                out duracaoConsultaMinutos))
            {
                this.consultaAdvogadoErrorProvider.SetError(this.duracaoConsultaMinutostextBox,
                                                 "Registo invalido");
                this.duracaoConsultaMinutostextBox.Focus();
            }
            //[2.2] v1
            else if (!soChave && (duracaoConsultaMinutos < 15 || duracaoConsultaMinutos > 120))
            {
                this.consultaAdvogadoErrorProvider.SetError(this.duracaoConsultaMinutostextBox,
                                                 "Tem de estar no intervalos de valres [15-120]");
                this.duracaoConsultaMinutostextBox.Focus();
            }
            //[2.2] v2
            else if (!soChave && duracaoConsultaMinutos < 15)
            {
                this.consultaAdvogadoErrorProvider.SetError(this.duracaoConsultaMinutostextBox,
                                                 "não pode ter menos de 15 min");
                this.duracaoConsultaMinutostextBox.Focus();
            }
            else if (!soChave && duracaoConsultaMinutos > 120)
            {
                this.consultaAdvogadoErrorProvider.SetError(this.duracaoConsultaMinutostextBox,
                                                 "não pode ter mais de 120 min");
                this.duracaoConsultaMinutostextBox.Focus();
            }
            else
            {
                ok = true;
            }
            return ok;
        }
