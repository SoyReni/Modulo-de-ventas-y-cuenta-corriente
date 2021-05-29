import React from 'react';
import { NavItem, NavLink, Nav, NavbarBrand, Navbar,Form,Button,Container } from 'react-bootstrap';

import GetPedidoVenta from './GetPedidoVenta';
import Informe from './Informe';
import CuentaCorriente from './CuentaCorriente';

class Navegacion extends React.Component {
    render() {
        return (
            //color ligth se usa para sarle fondo claros y color="dark" para darle fondo oscuro
            //md es la capacidad que tendra el navbar al colapsarse con el elemento dentro
            //ms = middle o medio 
           
               <>
            <Navbar bg="primary" variant="dark" >
          
            <Nav className="mr-auto">
            <NavItem><GetPedidoVenta /></NavItem>
            <NavItem><Informe /></NavItem>
            <NavItem><CuentaCorriente /></NavItem>
            </Nav>
            <Form inline>
           
            <Button color="primary">Cerrar Sesion</Button>
            </Form>
  </Navbar>

               </>

             
        );
    }
}
export default Navegacion;