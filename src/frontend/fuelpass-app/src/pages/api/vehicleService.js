export async function registerVehicle(data) {
    const response = await fetch('https://localhost:7016/api/vehicle/addvehicle', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
    });
    return response.json();
}

export async function getVehicle(data) {
    const response = await fetch(`https://localhost:7016/api/vehicle/checkVehicle/${data}`);
    return response.json();
}

export async function getAvailableQuota(startDate, endDate, vehicleId,typeId) {
    if(vehicleId != undefined && typeId != undefined ){
        const response = await fetch(`https://localhost:7016/api/fuel/GetAvailableQty?startDate=${startDate}&endDate=${endDate}&vehicleId=${vehicleId}&typeId=${typeId}`);
        return response.text();
    }

}