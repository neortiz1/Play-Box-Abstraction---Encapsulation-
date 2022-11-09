namespace Tetris
{
    public class GameGrid
    {
        
        //Crear una matriz bidimencional
        //La primera dimensión es la fila y la segunda dimensi{on es la columna
        //line1
        private 

        //Propiedades para la cantidad de filas y columnas
        //Indexador para facilitar el acceso a la matriz
        //line2
        public int 
        public int 

        //line3 
        public int this[int r, int c]
        {

        }
        //Con está indexación se puede ingresar directamente a un objeto de Gamegrid
        //El constructor tomará la cantidad de filas y columnas de los parametros. 
        //Número de columnas
        //Número de filas
        //line4
        public GameGrid(int rows, int columns)
        {

        }
        //En el body, se guarda el número de fila, columnas y se inicializa la matriz. 
        
        //Metodos convenciales
        //Verificar si una fila y una columan están dentro de la matriz o no.
        //line5
        public bool IsInside(int r, int c)
        {

        }

        //Verificar si una celda está vacia o no 
        //Debe estar dentro de la matriz y el valor de entrada en la matriz deber ser cero.
        //line6
        public bool IsEmpty(int r, int c)
        {

        }
        //Verificar si una fila completa está llena
        //line7
        public bool IsRowFull(int r)
        {

        }
        //Verificar si una fila está vacia
        //line8
        public bool IsRowEmpty(int r)
        {

        }
        //Cuando hay filas completas y deben borrarse
        //line9
        private void ClearRow(int r)
        {

        }
        //Cuando las filas de arriba deben moverse hacia abajo
        //line10
        private void MoveRowDown(int r, int numRows)
        {

        }
        //Cuando borramos las filas completas
        //line11
        public int ClearFullRows()
        {

        }
    }
}
