using Jogo_dos_Animais;
using Jogo_dos_Animais.GUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Jogo_Dos_Animais_Testes
{
    
    
    /// <summary>
    ///This is a test class for Class1Test and is intended
    ///to contain all Class1Test Unit Tests
    ///</summary>
    [TestClass()]
    public class TestJogo
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Class1 Constructor
        ///</summary>
        [TestMethod()]
        public void EstadoDoJogo()
        {
            //Instancia classe para apresentação das mensagens em tela
            IInteracaoComUsuario interacaoComUsuario = new InteracaoPorWindowsForm();

            //Classe aprende, responsavel por fazer a criação da nova habilidade e do animal
            Aprende aprende = new Aprende(interacaoComUsuario);

            //preserva o animal da resposta sim em todos os laços
            AfirmaVitoria afirmaVitoria = new AfirmaVitoria(interacaoComUsuario);

            //Cria animal para primeira execução do jogo
            Animal animalAquatico = new Animal(afirmaVitoria, aprende, "Baleia", interacaoComUsuario);
            Animal animalTerrestre = new Animal(afirmaVitoria, aprende, "Macaco", interacaoComUsuario);

            //Cria habilidade para primeira execução do jogo
            Habilitadade habilidade = new Habilitadade(animalAquatico, animalTerrestre, "vive na água", interacaoComUsuario);

            //Valida se habilidade criada não é nula
            Assert.IsNotNull(habilidade);

            //Executa o jogo dos animais até que o usuário queira sair
            do
            {
                habilidade.Executar(habilidade);
            }
            while (System.Windows.Forms.MessageBox.Show("Deseja jogar novamente", "", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }
    }
}
