import { useState } from 'react'

export function Login() {
    const [formData, setFormData] = useState({
        vehicleNumber: '',

    });
    const [errors, setErrors] = useState({});

    const validateForm = () => {
        let errors = {};

        if (!formData.vehicleNumber.trim()) {
            errors.vehicleNumber = 'Vehicle Number is required';
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
            <div className="row d-flex justify-content-center">
                <div className="col-md-6 mt-5">
                    <div className="card text-center">
                        <div className="card-header">
                            LOGIN
                        </div>
                        <div className="card-body">
                            <form onSubmit={handleSubmit}>
                                <div className="row g-3 align-items-center">
                                    <div className="col-md-2">
                                        <label className="col-form-label">Vehicle Number</label>
                                    </div>
                                    <div className="col-md-6">
                                        <input type="text" onChange={handleChange} className="form-control" />
                                        {errors.vehicleNumber && <span>{errors.vehicleNumber}</span>}
                                    </div>
                                    <div className="col-md-3">
                                        <span className="form-text">
                                            <button type="submit" className="btn btn-primary">Submit</button>
                                        </span>
                                    </div>
                                </div>

                            </form>
                        </div>
                    </div>
                </div >
            </div>
        </div>
    )

}

export default Login