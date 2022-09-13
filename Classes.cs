namespace Classes{
    public class cel{
        private float preco;
        private float tamanhoTela;
        private string modelo;

        public cel(float tamanhoTela, float preco, string modelo){
          this.tamanhoTela = tamanhoTela;
          this.preco = preco;
          this.modelo = modelo;
        }
        public string getModelo(){
			return this.modelo;
		}
         public float getPreco(){
			return this.preco;
		}
         public float getTamanhoTela(){
			return this.tamanhoTela;
		}

		public void setModelo(string modelo){
			this.modelo = modelo;
		}
        public void setPreco(float preco){
			this.preco = preco;
		}
        public void setTamanhoTela(float tamanhoTela){
			this.tamanhoTela = tamanhoTela;
		}
    }
}