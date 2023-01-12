import { Component } from "react";
import '../../assets/css/List.css';
import SideBar from "../../components/sideBar/SideBar";
import pacienteIcon from '../../assets/icons/paciente.svg';
import userIcon from '../../assets/icons/user.svg';
import moreIcon from '../../assets/icons/more.svg';

import Modal from '../../components/Modal/Modal';

class Paciente extends Component {
    constructor(props) {
        super(props);
        this.state = {
            listaPacientes: [],
            listaUsuarios: [],
            show: false,
            open: false,
            idUsuario: 0,
            nome: '',
            rg: '',
            telefone: '',
            cpf: '',
            endereco: '',
            dataNascimento: '',
            isLoading: false
        }
    }

    handleOpen = () => {
        this.setState({ open: true })
    };


    buscarPacientes = () => {
        fetch('http://localhost:5000/api/Prontuario')
            .then(resposta => resposta.json())
            .then(data => this.setState({ listaPacientes: data }))
            .catch(erro => console.log(erro));
    }
    buscarUsuarios = () => {
        fetch('http://localhost:5000/api/Usuario')
            .then(resposta => resposta.json())
            .then(data => this.setState({ listaUsuarios: data }))
            .catch(erro => console.log(erro));
    }

    cadastrarPacientes = (event) => {
        event.preventDefault();
        this.setState({ isLoading: true });

        let paciente = {
            IdUsuario: this.state.idUsuario,
            Nome: this.state.nome,
            Rg: this.state.rg,
            Telefone: this.state.telefone,
            Cpf: this.state.cpf,
            Endereco: this.state.endereco,
            DataNascimento: this.state.dataNascimento,
        };

        fetch('http://localhost:5000/api/Prontuario', {
            method: 'POST',
            body: JSON.stringify(paciente),
            headers: {
                "Content-Type": "application/json",
            }
        })
            .then(resposta => {
                if (resposta.status === 201) {
                    this.setState({ isLoading: false });
                }
            })
            .then(
                this.buscarPacientes
            )
    }

    atualizaStateCampo = (campo) => {
        this.setState({ [campo.target.name]: campo.target.value })
        console.log(campo.target.value)
    };

    componentDidMount() {
        this.buscarPacientes();
        this.buscarUsuarios();
    }

    render() {
        return (

            <div className='Body'>
                <SideBar />
                <div className='Content'>


                    <header className='Header'>
                        <div className='tituloButton'>
                            <div className='tituloIcon'>
                                <figure>
                                    <img src={pacienteIcon} alt='Icone de pacientes' />
                                </figure>
                                <p>Lista de pacientes</p>
                            </div>
                            <div className='buttonAdd'>
                                <Modal>
                                    <div className='formContent'>
                                        <header>
                                            <h1>Cadastro de paciente (prontuario)</h1>
                                        </header>
                                        <form className='modalForm' onSubmit={this.cadastrarPacientes}>
                                            <select className='listSelect' name='idUsuario' type='text' value={this.state.idUsuario} onChange={this.atualizaStateCampo}>
                                                <option value='0'>Selecione o usuário</option>
                                                {
                                                    this.state.listaUsuarios.map(usuario => {
                                                        return (
                                                            <option key={usuario.idUsuario} value={usuario.idUsuario}>
                                                                {usuario.nome}
                                                            </option>
                                                        )
                                                    })
                                                }
                                            </select>

                                            <input placeholder='Nome' type='text' value={this.state.nome} name='nome' onChange={this.atualizaStateCampo} />
                                            <input placeholder='RG' type='text' value={this.state.rg} name='rg' onChange={this.atualizaStateCampo} />
                                            <input placeholder='Telefone' type='text' value={this.state.telefone} name='telefone' onChange={this.atualizaStateCampo} />
                                            <input placeholder='CPF' type='text' value={this.state.cpf} name='cpf' onChange={this.atualizaStateCampo} />
                                            <input placeholder='Endereço' type='text' value={this.state.endereco} name='endereco' onChange={this.atualizaStateCampo} />
                                            <input placeholder='Data de Nascimento' type='date' value={this.state.dataNascimento} name='dataNascimento' onChange={this.atualizaStateCampo} />
                                            <span style={{width: '100%'}}></span>

                                            {
                                                this.state.isLoading === true &&
                                                <button type="submit" disabled style={{ backgroundColor: 'rgba(131, 190, 223, 0.5)', cursor: 'wait' }}>
                                                    Cadastrando...
                                                </button>
                                            }
                                            {
                                                this.state.isLoading === false &&
                                                <button type="submit"
                                                    disabled={this.state.nome === '' || this.state.email === '' || this.state.senha === '' ? 'none' : ''}
                                                >
                                                    Cadastrar
                                                </button >
                                            }
                                        </form>
                                    </div>
                                </Modal>
                            </div>
                        </div>
                        <div className='infos'>
                            <div className='countUsers'>
                                <span>{this.state.listaPacientes.length}</span>
                                <p>pacientes</p>
                            </div>
                            <div className='options'>
                                <form >
                                    <label>Listar por: </label>
                                    <select>
                                        <option>Ordem padrão</option>

                                    </select>
                                </form>
                            </div>
                        </div>
                    </header>
                    <main className='list'>
                        <ul>
                            {
                                this.state.listaPacientes.map(paciente => {
                                    return (
                                        <li key={paciente.idProntuario}>
                                            <figure>
                                                <img src={userIcon} alt='Icone de usuário' />
                                            </figure>
                                            <div className='nomeEmail'>
                                                <p>{paciente.nome !== '' ? paciente.nome : '-'}</p>
                                                <p className='subInfo'>{paciente.idUsuarioNavigation.email !== '' ? paciente.idUsuarioNavigation.email : '-'}</p>
                                            </div>
                                            <div>
                                                <p>{paciente.telefone !== '' ? paciente.telefone : '-'}</p>
                                            </div>
                                            <div>
                                                <p>{paciente.dataNascimento !== '' ?  Intl.DateTimeFormat("pt-BR").format(new Date(paciente.dataNascimento)) : '-'}</p>
                                            </div>
                                            <div>
                                                <p className='textJustify'>{paciente.endereco !== '' ? paciente.endereco : '-'}</p>
                                            </div>
                                            <figure>
                                                <img src={moreIcon} alt='Icone de mais opções' />
                                            </figure>
                                        </li>
                                    );
                                })
                            }
                        </ul>
                    </main>
                </div>
            </div>
        )
    }
}

export default Paciente;