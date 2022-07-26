import Button from '../Components/Button';
import Input from '../Components/Input';

const Buscador = ({onChangeFunction}) => {

//    const handleChange = (e) =>{
//     onChangeFunction(e)
//     }
    return(
        <>
            <form className='border'>
                <div className="card-container">
                    <div className="container-info">
                        <Input
                            className={"datePicker"}
                            label={"Desde"}
                            name={"from"}
                            type={"date"}
                            key="from"
                            required={false}
                            onChangeFunction={(e) => onChangeFunction(e)}
                        />
                        <Input
                            className={"datePicker"}
                            label={"Hasta"}
                            name={"to"}
                            type={"date"}
                            key="to"
                            required={false}
                           onChangeFunction={(e) => onChangeFunction(e)}
                        />
                    </div>
                    <div className="container-info">
                        <Input
                            className={""}
                            label={"Palabras Clave"}
                            name={"keyword"}
                            type={"text"}
                            key="keyword"
                            required={true}
                            onChangeFunction={(e) => onChangeFunction(e)}
                        />      
                    </div>
                </div>
            </form>
        </>
    )
}

export default Buscador;