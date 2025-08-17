import React from 'react';
import { Routes, Route } from 'react-router-dom';
import { Box } from '@chakra-ui/react';
import HomePage from './pages/HomePage';

/**
 * Main App component that handles routing and layout
 * Uses React Router for client-side navigation
 */
function App() {
  return (
    <Box minH="100vh" bg="gray.50">
      <Routes>
        <Route path="/" element={<HomePage />} />
        {/* Add more routes here as the app grows */}
      </Routes>
    </Box>
  );
}

export default App;
