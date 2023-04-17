import { useState, useEffect } from 'react';

function MyComponent() {
  const [data, setData] = useState(null);

  useEffect(() => {
    const fetchData = async () => {
      const res = await fetch('https://localhost:7016/api/vehicle/allVehicle');
      const text = await res.text();
      const json = JSON.parse(text);
      setData(json);
      console.log(json);
    };
    fetchData();
  }, []);

  return (
    <div>
      {/* render the data */}
    </div>
  );
}

export default MyComponent;

