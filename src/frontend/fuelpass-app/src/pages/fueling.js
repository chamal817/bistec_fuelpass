import { useState } from 'react'
import { getVehicle, getAvailableQuota } from './api/vehicleService'


export function Fueling() {
    const [formData, setFormData] = useState({
        vehicleNumber: '',
    });
    const [errors, setErrors] = useState({});
    const [availableQuota, setAvailableQuota] = useState('');

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
            getData(formData)
        } else {
            setErrors(errors);
        }
        createDate();
    }


    async function getData(formData) {
        const response = await getVehicle(formData.vehicleNumber);
        if (response.result) {
            console.log(response)
            createDate(response.result[0].id,response.result[0].vehicleType)
           
        }

    }
    function createDate(vehicleId,vehicleTypeId) {
        var currentDate = new Date;
        var first = currentDate.getDate() - currentDate.getDay();
        var last = first + 6;

        var firstDay = new Date(currentDate.setDate(first));
        var lastDay = new Date(currentDate.setDate(last));

        var formattedFirstDay = firstDay.toISOString().slice(0, 10);
        var formattedLastDay = lastDay.toISOString().slice(0, 10);
        checkAvailableQuota(formattedFirstDay ,formattedLastDay,vehicleId,vehicleTypeId)


    }

    async function checkAvailableQuota(startDate , endDate ,vehicleId,vehicleTypeId ) {
        const response = await getAvailableQuota(startDate,endDate,vehicleId,vehicleTypeId);
        setAvailableQuota(response)
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
                            Fulling
                        </div>
                       
                        <div className="card-body">
                            <form onSubmit={handleSubmit}>
                                <div className="row g-3 align-items-center">
                                    <div className="col-md-2">
                                        <label className="col-form-label">Vehicle Number</label>
                                    </div>
                                    <div className="col-md-6">
                                        <input type="text" name="vehicleNumber" onChange={handleChange} className="form-control" />
                                        {errors.vehicleNumber && <span>{errors.vehicleNumber}</span>}
                                    </div>
                                    <div className="col-md-3">
                                        <span className="form-text">
                                            <button type="submit" className="btn btn-primary">Submit</button>
                                        </span>
                                    </div>
                                </div>

                            </form>

                            <div>Available Quota :  {availableQuota}</div>
                        </div>
                    </div>
                </div >
            </div>
        </div>
    )

}

export default Fueling