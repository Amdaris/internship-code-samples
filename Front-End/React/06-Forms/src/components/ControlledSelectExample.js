import { useState } from 'react';

const sports = [
  'Football',
  'Basketball',
  'Volley',
  'Golf',
  'Gymnastics',
];

const ControlledSelectExample = () => {
  const [favoriteSport, setFavoriteSport] = useState('football');

  return (
    <label>
      Pick your favorite sport
      <select onChange={(e) => setFavoriteSport(e.target.value)}>
        {sports.map((sport) => (
          <option value={sport.toLowerCase()}>{sport}</option>
        ))}
      </select>
      Currently Selected: {favoriteSport}
    </label>
  );
};

export default ControlledSelectExample;



