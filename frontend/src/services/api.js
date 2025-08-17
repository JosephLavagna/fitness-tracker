import axios from 'axios';

/**
 * API service configuration and functions
 * Handles all HTTP requests to the .NET backend
 */

// Configure axios instance with base URL
const api = axios.create({
  baseURL: process.env.REACT_APP_API_URL || 'http://localhost:5000/api',
  timeout: 10000,
  headers: {
    'Content-Type': 'application/json',
  },
});

// Request interceptor for adding auth tokens (if needed in future)
api.interceptors.request.use(
  (config) => {
    // Add auth token if available
    // const token = localStorage.getItem('authToken');
    // if (token) {
    //   config.headers.Authorization = `Bearer ${token}`;
    // }
    return config;
  },
  (error) => {
    return Promise.reject(error);
  }
);

// Response interceptor for error handling
api.interceptors.response.use(
  (response) => response,
  (error) => {
    console.error('API Error:', error.response?.data || error.message);
    return Promise.reject(error);
  }
);

/**
 * Coach-related API functions
 */
export const coachAPI = {
  // Get all coaches
  getAll: async () => {
    try {
      const response = await api.get('/coaches');
      return response.data;
    } catch (error) {
      throw new Error(`Failed to fetch coaches: ${error.message}`);
    }
  },

  // Get coach by ID
  getById: async (id) => {
    try {
      const response = await api.get(`/coaches/${id}`);
      return response.data;
    } catch (error) {
      throw new Error(`Failed to fetch coach: ${error.message}`);
    }
  },

  // Get featured coaches (for homepage)
  getFeatured: async () => {
    try {
      const response = await api.get('/coaches/featured');
      return response.data;
    } catch (error) {
      throw new Error(`Failed to fetch featured coaches: ${error.message}`);
    }
  },
};

/**
 * Program-related API functions (for future expansion)
 */
export const programAPI = {
  // Get all programs
  getAll: async () => {
    try {
      const response = await api.get('/programs');
      return response.data;
    } catch (error) {
      throw new Error(`Failed to fetch programs: ${error.message}`);
    }
  },
};

export default api;
