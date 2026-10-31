import { useState } from "react";
import type { GarageItem } from "../types";
import { removeFromGarage } from "../api";

type GarageProps = {
  items: GarageItem[];
  loading: boolean;
  error: string | null;
  onRemoved: (garageItemId: number) => void;
};

export default function Garage({
  items,
  loading,
  error,
  onRemoved,
}: GarageProps) {
  const [message, setMessage] = useState<string | null>(null);

  async function handleRemove(garageItemId: number) {
    try {
      await removeFromGarage(garageItemId);
      //setItems(items.filter((i) => i.garageItemId !== garageItemId));
      onRemoved(garageItemId);
      setMessage("item removed from garage");
    } catch {
      setMessage("item failed to remove from garage");
    }
  }

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
      {message && <p>{message}</p>}
      <table>
        <thead>
          <tr>
            <th>Vehicle</th>
            <th>Game</th>
            <th>Class</th>
            <th>Added</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {items.map((item) => (
            <tr key={item.garageItemId}>
              <td>{item.vehicleName}</td>
              <td>{item.gameName}</td>
              <td>{item.class}</td>
              <td>{new Date(item.dateAdded).toLocaleString()}</td>
              <td>
                <button onClick={() => handleRemove(item.garageItemId)}>
                  Remove
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
