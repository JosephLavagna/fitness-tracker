import { extendTheme } from '@chakra-ui/react';

/**
 * Custom Chakra UI theme configuration
 * Inspired by Linear's modern, clean design
 */
const theme = extendTheme({
  // Color palette inspired by fitness and strength
  colors: {
    brand: {
      50: '#E6F3FF',
      100: '#BAE0FF',
      200: '#8CCEFF',
      300: '#5EBBFF',
      400: '#30A9FF',
      500: '#0196FF', // Primary brand color - vibrant blue
      600: '#0178CC',
      700: '#015A99',
      800: '#003C66',
      900: '#001E33',
    },
    accent: {
      50: '#FFF5E6',
      100: '#FFE4BA',
      200: '#FFD38C',
      300: '#FFC25E',
      400: '#FFB130',
      500: '#FFA000', // Secondary accent - energetic orange
      600: '#CC8000',
      700: '#996000',
      800: '#664000',
      900: '#332000',
    },
  },
  
  // Typography settings for readability and hierarchy
  fonts: {
    heading: `'Inter', -apple-system, BlinkMacSystemFont, "Segoe UI", Helvetica, Arial, sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol"`,
    body: `'Inter', -apple-system, BlinkMacSystemFont, "Segoe UI", Helvetica, Arial, sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol"`,
  },
  
  // Component style overrides
  components: {
    Button: {
      baseStyle: {
        fontWeight: 'semibold',
        borderRadius: 'lg',
      },
      variants: {
        // Primary button style
        solid: {
          bg: 'brand.500',
          color: 'white',
          _hover: {
            bg: 'brand.600',
            transform: 'translateY(-2px)',
            boxShadow: 'lg',
          },
          _active: {
            bg: 'brand.700',
            transform: 'translateY(0)',
          },
          transition: 'all 0.2s',
        },
        // Secondary button style
        outline: {
          borderColor: 'brand.500',
          color: 'brand.500',
          _hover: {
            bg: 'brand.50',
            transform: 'translateY(-1px)',
          },
          _active: {
            bg: 'brand.100',
            transform: 'translateY(0)',
          },
          transition: 'all 0.2s',
        },
      },
    },
    Heading: {
      baseStyle: {
        color: 'gray.800',
        lineHeight: 'shorter',
      },
    },
    Text: {
      baseStyle: {
        color: 'gray.700',
        lineHeight: 'tall',
      },
    },
  },
  
  // Global styles
  styles: {
    global: {
      body: {
        bg: 'gray.50',
        color: 'gray.800',
      },
    },
  },
});

export default theme;
