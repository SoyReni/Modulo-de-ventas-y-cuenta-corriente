import logo from './logo.svg';
import './App.css';
import MaterialTable from 'material-table'
import 'bootstrap/dist/css/bootstrap.min.css';
import {Table,Row ,Container,Button} from 'react-bootstrap';
import PedidoVenta from './Componentes/PedidoVenta';
import Navegacion from './Componentes/Navegacion';

function App() {

   
    return (
        <div>
            
            <Navegacion/>
            
            <Row>
                <PedidoVenta/>

                
            </Row>

            {/*<Row>
                <div  className="text-align: center">
            <Button type="button" class="btn btn-lg btn-primary">Nuevo</Button>
            
            </div>
            </Row>
            */}
           
           
          
     
        </div>
    
    
    
        )}


export default App;