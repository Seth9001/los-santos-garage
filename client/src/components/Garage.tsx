import { useEffect, useState } from "react";
import type { GarageItem } from "../types";
import { getGarage } from "../api";
export default function Garage() {
  const [items, setItems] = useState<GarageItem[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    async function load() {
      try {
        const myGarage = await getGarage();
        setItems(myGarage);
      } catch {
        setError("Failed to load garage. Is the API running?");
      } finally {
        setLoading(false);
      }
    }
    load();
  }, []);

  if (loading) {
    return <p>Loading...</p>;
  }
  if (error) {
    return <p>{error}</p>;
  }
  if (items.length === 0) {
    return (
      <>
        <h1>Garage</h1>
        <p>Garage is empty</p>
      </>
    );
  }

  return (
    <div>
      <h1>Garage</h1>
      <table>
        <thead>
          <tr>
            <th>Vehicle</th>
            <th>Game</th>
            <th>Class</th>
            <th>Added</th>
          </tr>
        </thead>
        <tbody>
          {items.map((item) => (
            <tr key={item.garageItemId}>
              <td>{item.vehicleName}</td>
              <td>{item.gameName}</td>
              <td>{item.class}</td>
              <td>{new Date(item.dateAdded).toLocaleString()}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
