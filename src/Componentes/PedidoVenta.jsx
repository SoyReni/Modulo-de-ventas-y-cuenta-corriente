import React,{useState} from 'react';
import './PedidoVenta.css';
import MaterialTable,{MTableToolbar } from 'material-table'
import 'bootstrap/dist/css/bootstrap.min.css';
import {listaVenta} from '../listaVenta.json';
import {Table,Container} from 'react-bootstrap';
import { StylesProvider } from '@material-ui/styles';
import { Button } from 'bootstrap';
import { IconButton } from '@material-ui/core';

class PedidoVenta extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
          listaVenta,
         
        };


        
      }

     

     
   
     render(){
        const columns=[
            { title: 'ID', field: 'i',type:'numeric' },
            { title: 'Fecha de emision',field: 'fecha'},
            {  title: 'Encargado',field: 'encargado' },
            { title: 'Cliente' ,field: 'cliente'},
            { title: 'Estado',field: 'estado'}
    
         ]

         const handleRowDelete = (oldData, resolve) => { 
          delete ("/ listaVenta /" + oldData.i). 
            then (res => { 
              const dataDelete = [this.state.listaVenta]; 
              const index = oldData.tableData.id ; 
              dataDelete.splice (index, 1); 
              this.state.setData ([... dataDelete]); 
              resolve () 
            }) 
            
        }

        const deletet = (listaVentaI)=>{
          const filtrar=this.state.listaVenta.filter(listaVenta=> listaVenta.i !== listaVentaI);
          this.setState({listaVenta:filtrar}); 
         
  
         };

      
        
    
    return (
    <Container>
            <Table bordered hover responsive>
            <MaterialTable
           
             columns={columns}
            data={this.state.listaVenta}
            title='Acciones'
            actions={[
              /*  {
                    icon:'edit',
                    tooltip:'Modificar  estado',
                    onclick:(event ,rowdata)=>alert('Has presionado editar proceso',+rowdata.proceso)
                },*/
               /* {
                icon:'delete',
                tooltip:'Eliminar Pedido',
                onclick:(event,rowdata)=>deletet(rowdata)
            },*/
          {
          icon:'check',
          tooltip:'Facturar'

          },
          {
            icon:'saveAlt ',
            tooltip:'Emitir factura'
  
            }
          
          ]}

           
            localization={{
                header:{
                actions: 'Opciones',
                },

                body:{
                  deleteTooltip:'Eliminar',
                  editRow:{
                    deleteText:'Estas seguro que seas eliminarlo',

                  }
                },
                pagination:{
                  labelRowsSelect:'Filas',

                },
                toolbar:{
                  searchTooltip:'Buscar',
                  searchPlaceholder:'Buscar'


                }
            }}


            editable={{
            
          
              onRowDelete:oldData=>
           
              new Promise((resolve,reject)=>{
                setTimeout(()=>{
                  const dataDelete=[...this.state.listaVenta];
                  const index=oldData.tableData.i;
                  dataDelete.splice(index,1);
                  this.setState({ listaVenta: [...dataDelete] });
                  resolve();


                },1000)
              }),
          
            onRowUpdate:(newData, oldData) =>
            new Promise((resolve, reject) => {
                setTimeout(() => {
                    const dataUpdate = [...this.state.listaVenta];
                    const index = oldData.tableData.i;
                    dataUpdate[index] = newData;
                    this.setState({ listaVenta: [...dataUpdate] });

                    resolve();
                }, 1000);
            }),}

          }

            components={{
                Toolbar: props => (
                  <div>
                    <MTableToolbar {...props} />
                    <div color="primary" style={{padding: '0px 10px' ,  color: '#039be5'}}>
                  
                    
                    </div>
                  </div>
                ),
              }}

              options={{
                actionsColumnIndex: -1,
                showTitle: false,
                search:true,
              //  filtering: true,
                
                headerStyle: {
                    backgroundColor: '#039be5',
                    color: '#FFF'
                  }

            }}

           



             

              
            />
            
            
              
  
        </Table>
       
        
        </Container>
    );
        }
}

export default PedidoVenta;