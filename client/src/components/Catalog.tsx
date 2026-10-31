import { useEffect, useState } from "react";
import type { CatalogItem, GarageItem } from "../types";
import { getCatalogItems, addToGarage } from "../api";

type CatalogProps = {
  onAdded: (item: GarageItem) => void;
};

export default function Catalog({ onAdded }: CatalogProps) {
  const [items, setItems] = useState<CatalogItem[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [message, setMessage] = useState<string | null>(null);

  useEffect(() => {
    async function load() {
      try {
        const data = await getCatalogItems();
        setItems(data);
      } catch {
        setError("Failed to load the catalog. Is the API running?");
      } finally {
        setLoading(false);
      }
    }
    load();
  }, []);

  async function handleAdd(vehicleGameId: number) {
    try {
      const added = await addToGarage(vehicleGameId);
      setMessage(
        `Added ${added.vehicleName} (${added.gameName}) to your garage!`,
      );
      onAdded(added);
    } catch {
      setMessage(`Failed to add vehicle of ID: ${vehicleGameId}`);
    }
  }

  if (loading) {
    return <p>Loading...</p>;
  }

  if (error) {
    return <p>{error}</p>;
  }

  return (
    <div>
      <h1>Catalog list</h1>
      <p>we have {items.length} vehicles</p>
      {message && <p>{message}</p>}
      <table>
        <thead>
          <tr>
            <th>Vehicle</th>
            <th>Game</th>
            <th>Class</th>
            <th></th>
          </tr>
        </thead>

        <tbody>
          {items.map((item) => (
            <tr key={item.vehicleGameId}>
              <td>{item.vehicleName}</td>
              <td>{item.gameName}</td>
              <td>{item.class}</td>
              <td>
                <button onClick={() => handleAdd(item.vehicleGameId)}>
                  Add
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
