import { useState, useEffect } from 'react';
import { coachAPI } from '../services/api';

/**
 * Custom hook for fetching and managing coaches data
 * Provides loading states and error handling
 */
export const useCoaches = () => {
  const [coaches, setCoaches] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchCoaches = async () => {
      try {
        setLoading(true);
        setError(null);
        const data = await coachAPI.getAll();
        setCoaches(data);
      } catch (err) {
        setError(err.message);
        console.error('Error fetching coaches:', err);
      } finally {
        setLoading(false);
      }
    };

    fetchCoaches();
  }, []);

  return { coaches, loading, error };
};

/**
 * Custom hook for fetching featured coaches
 * Used on the homepage to showcase top coaches
 */
export const useFeaturedCoaches = () => {
  const [featuredCoaches, setFeaturedCoaches] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchFeaturedCoaches = async () => {
      try {
        setLoading(true);
        setError(null);
        const data = await coachAPI.getFeatured();
        setFeaturedCoaches(data);
      } catch (err) {
        setError(err.message);
        console.error('Error fetching featured coaches:', err);
      } finally {
        setLoading(false);
      }
    };

    fetchFeaturedCoaches();
  }, []);

  return { featuredCoaches, loading, error };
};
