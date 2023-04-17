import { useState } from 'react'
import { registerVehicle } from './api/vehicleService'
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

            saveVehicle(formData)
        } else {
            setErrors(errors);
        }

    }


    const handleChange = (event) => {
        setFormData({ ...formData, [event.target.name]: event.target.value });
    }

    function saveVehicle(formData) {
        const response = registerVehicle(formData);
        if (response) {
            setFormData({
                vehicleNumber: '',
                chassisNumber: '',
                vehicleType: '',
            });
        }

    }

        return (

            <div>
               
                <div className="row d-flex justify-content-center">
                    <div className="col-md-6 mt-5">
                        <div className="card text-center">
                            <div className="card-header">
                                REGISTRATION
                            </div>
                            <div className="card-body">
                                <form onSubmit={handleSubmit}>
                                    <div className="row">
                                        <div className="col-md-6">
                                            <label className='d-flex justify-content-start'>Vehicle Number</label>
                                            <input type="text" className="form-control mt-1" onChange={handleChange} name="vehicleNumber" placeholder="Vehicle Number" />
                                            {errors.vehicleNumber && <span>{errors.vehicleNumber}</span>}
                                        </div>
                                        <div className="col-md-6">
                                            <label className='d-flex justify-content-start'>Vehicle Type</label>
                                            <select onChange={handleChange} name="vehicleType" className="form-select mt-1">
                                                <option value={0}>Select Type</option>
                                                <option value={1}>Bike</option>
                                                <option value={2}>Car</option>
                                                <option value={3}>Bus</option>
                                                <option value={4}>Lorry</option>
                                                <option value={5}>Van</option>
                                                <option value={6}>Three Wheel</option>
                                            </select>
                                            {errors.vehicleType && <span className=''>{errors.vehicleType}</span>}
                                        </div>
                                    </div>
                                    <div className="row mt-3">
                                        <div className="col-md-6">
                                            <label className='d-flex justify-content-start'>Chassis Number</label>
                                            <input type="text" className="form-control mt-1" onChange={handleChange} name="chassisNumber" placeholder="Chassis Number" />
                                            {errors.chassisNumber && <span>{errors.chassisNumber}</span>}
                                        </div>
                                        <div className='col-md-4 mt-4'> <button type="submit" className="btn btn-primary">Submit</button></div>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div></div>
            </div>
        );


    }
    export default Register