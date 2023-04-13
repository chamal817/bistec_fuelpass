import { useState } from 'react'
export function Register() {

    const [formData, setFormData] = useState({
        vehicleNumber: '',
        chassisNumber: '',
        vehicleType: '',

    });
    const [errors, setErrors] = useState({});

    const validateForm = () => {
        let errors = {};

        if (!formData.vehicleNumber.trim()) {
            errors.vehicleNumber = 'Vehicle Number is required';
        }
        if (!formData.chassisNumber.trim()) {
            errors.chassisNumber = 'Chassis Number is required';
        }

        if (formData.vehicleType == 0) {
            errors.vehicleType = 'Vehicle Type is required';
        }

        return errors;
    }
    const handleSubmit = (event) => {
        event.preventDefault();
        const errors = validateForm();
        if (Object.keys(errors).length === 0) {
            console.log(formData);
        } else {
            setErrors(errors);
        }

    }


    const handleChange = (event) => {
        setFormData({ ...formData, [event.target.name]: event.target.value });
    }
    return (

        <div>
            <form onSubmit={handleSubmit}>
                <div className="row">
                    <div className="col-md-6">
                        <label>Vehicle Number</label>
                        <input type="text" className="form-control" onChange={handleChange} name="vehicleNumber" placeholder="Vehicle Number" />
                        {errors.vehicleNumber && <span>{errors.vehicleNumber}</span>}
                    </div>
                    <div className="col-md-6">
                        <label>Vehicle Type</label>
                        <select id="inputState" onChange={handleChange} name="vehicleType" className="form-control">
                            <option value={0}>Select Type</option>
                            <option value={1}>Car</option>
                            <option value={2}>Bike</option>
                        </select>
                        {errors.vehicleType && <span className=''>{errors.vehicleType}</span>}
                    </div>
                </div>
                <div className="row">
                    <div className="col-md-4">
                        <label >Chassis Number</label>
                        <input type="text" className="form-control" onChange={handleChange} name="chassisNumber" placeholder="Chassis Number" />
                        {errors.chassisNumber && <span>{errors.chassisNumber}</span>}
                    </div>
                    <div className='col-md-4 mt-4'> <button type="submit" className="btn btn-primary">Submit</button></div>
                </div>
            </form>
        </div>
    );


}
export default Register