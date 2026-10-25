import { useEffect, useState } from "react";
import type { CatalogItem } from "../types";
import { getCatalogItems } from "../api";
export default function Catalog() {
  const [items, setItems] = useState<CatalogItem[]>([]);

  useEffect(() => {
    async function load() {
      const data = await getCatalogItems();
      setItems(data);
    }
    load();
  }, []);

  return (
    <div>
      <h1>Catalog list</h1>
      <p>we have {items.length} vehicles</p>

      <table>
        <thead>
          <tr>
            <th>Vehicle</th>
            <th>Game</th>
          </tr>
        </thead>

        <tbody>
          {items.map((item) => (
            <tr key={item.vehicleGameId}>
              <td>{item.vehicleName}</td>
              <td>{item.gameName}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
