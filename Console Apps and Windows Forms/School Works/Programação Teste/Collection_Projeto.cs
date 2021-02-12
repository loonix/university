 public class ProjetoCollection : List<Projeto>
    {

        #region Contrutor

        public ProjetoCollection(DataTable dataTable)
        {
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.AsEnumerable())
                {
                    Projeto projeto = new Projeto();

                    projeto.IDProjeto = dataRow.Field<string>("IDProjeto");
                    projeto.Descricao = dataRow.Field<string>("Descricao"); 
                    projeto.DataInicio = dataRow.Field<DateTime>("DataInicio"); 
                    projeto.DataFim = dataRow.Field<DateTime>("DataFim"); 
                    projeto.Valor = dataRow.Field<float>("Valor");

                    this.Add(projeto);
                }   
            }
        }

        #endregion

        #region Metodos

        public float ObterTotalValor()
        {
            float totalValorProjetos = 0;

            foreach (Projeto projeto in this)
            {
                totalValorProjetos += projeto.Valor;
            }

            return totalValorProjetos;
        }

        public float ObterTotalValorV2()
        {
            // SELECT SUM(Valor) FROM Projeto WHERE ID = 5
            // FROM Projeto WHERE ID = 5 SELECT SUM(Valor) 
            float totalValorProjetos = (from element in this
                                        select element.Valor).Sum();

            return totalValorProjetos;
        }

        public float ObterMediaValor()
        {
            float mediaValorProjetos = (from element in this
                                        select element.Valor).Average();

            return mediaValorProjetos;
        }

        public float ObterTotalValorProjetosPagos()
        {
            float totalValorProjetos = (from element in this
                                        where (element.Atributo & AtributoProjetoEnum.Pago) == AtributoProjetoEnum.Pago
                                        select element.Valor).Sum();

            return totalValorProjetos;
        }

        public float ObterTotalValorProjetosPagosV2()
        {
            float totalValorProjetos = (from element in this
                                        where element.AtributoPago()
                                        select element.Valor).Sum();

            return totalValorProjetos;
        }

        public float ObterTotalValorProjetosPagosV3()
        {
            float totalValorProjetos = this.Where(k => k.AtributoPago()).Sum(k => k.Valor); 

            return totalValorProjetos;
        }

        public float ObterTotalValorProjetos(GrauEnum grau)
        {
            float totalValorProjetos = (from element in this
                                        where element.Grau == grau
                                        select element.Valor).Sum();

            return totalValorProjetos;
        }

        //Calcular quantos projetos estão ativos na data de Hoje, utilizando a camada de negocio usando linq
        public int CalcularProjetosAtivos()
        {
            int numeroProjetos = 0;

            //V1
            numeroProjetos = (from element in this
                              where element.DataInicio <= DateTime.Today && element.DataFim >= DateTime.Today
                              select element).Count();

            //V1.2
            numeroProjetos = (from Projeto projeto in this
                              where projeto.DataInicio <= DateTime.Today && projeto.DataFim >= DateTime.Today
                              select projeto).Count();

            //V2
            numeroProjetos = this.Count(k => k.DataInicio <= DateTime.Today && k.DataFim >= DateTime.Today);

            return numeroProjetos;
        }

        public void CalcularValorDiaProjetoGrauElevado(out float totalValores, out int totalDias)
        {
            totalValores = 0;
            totalDias = 0;

            totalValores = (from element in this
                                  where element.Grau == GrauEnum.Elevado
                                  select element.Valor).Sum();

            totalDias = (int)(from element in this
                              where element.Grau == GrauEnum.Elevado
                              select element.DataFim.Subtract(element.DataInicio).TotalDays).Sum();
        }

        //Defina uma função que retorne o projeto com maior numero de dias, de um Grau X dado como argumento,
        //Mostre na textBox "resultadoExercicio6TextBox" a descrição desse projeto
        //utilizando a camada de negocio usando linq
        public Projeto CalcularProjetoMaiorValor(GrauEnum grau)
        {
            Projeto projeto = null;

            //V1
            projeto = (from element in this
                       where element.Grau == grau
                       orderby element.Valor descending
                       select element).FirstOrDefault();

            //V2
            projeto = (from element in this
                       where element.Grau == grau
                       select element).OrderByDescending(k => k.Valor).FirstOrDefault();

            //V3
            projeto = this.OrderByDescending(k => k.Valor).FirstOrDefault(k =>k.Grau == grau);

            return projeto;
        }

        //Defina uma função que retorne o total do valores e o total do nº de dias do projeto, dos projetos de Grau Elevado
        //utilizando a camada de negocio usando linq
        public float CalcularValorDiaProjetoGrauElevado(out int totalDias)
        {
            totalDias = 0;

            float totalValores = (from element in this
                                where element.Grau == GrauEnum.Elevado
                                select element.Valor).Sum();

            totalDias = (int)(from element in this
                              where element.Grau == GrauEnum.Elevado
                              select element.DataFim.Subtract(element.DataInicio).TotalDays).Sum();

            return totalValores;
        }

        //Calcular o valor total dos projetos que começam no ano X, em que X é dado como argumento, utilizando a camada de negocio usando linq
        public float CalcularValorProjetoDoAno(int ano)
        {
            float totalValor = 0;

            //V0
            foreach (Projeto projeto in this)
            {
                if (projeto.DataInicio.Year == ano)
                {
                    totalValor++;
                }
            }

            //V1
            totalValor = (from element in this
                          where element.DataInicio.Year == ano
                          select element.Valor).Sum();

            //V2
            totalValor = this.Where(k => k.DataInicio.Year == ano).Sum(k => k.Valor);

            return totalValor;
        }

        //Obter a lista de projetos que ainda não terminaram, e mostrar na listbox a descrição dos projetos, utilizando a camada de negocio usando linq
        public IEnumerable<Projeto> ObterProjetosPorTerminar()
        {
            //V1
            IEnumerable<Projeto> projetos = from element in this
                                            where element.DataFim >= DateTime.Today
                                            select element;

            //V2
            IEnumerable<Projeto> projetos2 = this.Where(k => k.DataFim >= DateTime.Today);

            return projetos;
        }

        //Obter a lista de projetos que estão ativos ainda nos próximos X meses, 
        //em que X é dado pelo valor da "numeroMesesParaAcabarTextBox", e mostrar na listbox a descrição dos projetos, 
        //utilizando a camada de negocio usando linq
        public IEnumerable<Projeto> ObterProjetosPorTerminar(int numeroMeses)
        {
            //V1
            IEnumerable<Projeto> projetos = from element in this
                                            where element.DataInicio <= DateTime.Today &&
                                                  element.DataFim >= DateTime.Today &&
                                                  element.DataFim <= DateTime.Today.AddMonths(numeroMeses)
                                            select element;

            //V2
            IEnumerable<Projeto> projetos2 = this.Where(k => k.DataInicio <= DateTime.Today &&
                                                             k.DataFim >= DateTime.Today &&
                                                             k.DataFim <= DateTime.Today.AddMonths(numeroMeses));


            //V3
            IEnumerable<Projeto> projetos3 = from element in this
                                            where element.ActivoNosProximosXMeses(numeroMeses)
                                            select element;


            return projetos;
        }


        #endregion
    }