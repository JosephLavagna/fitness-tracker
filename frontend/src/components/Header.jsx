import React from 'react';
import {
  Box,
  Flex,
  HStack,
  Link,
  Button,
  useColorModeValue,
  Container,
  Text,
} from '@chakra-ui/react';

/**
 * Navigation header component
 * Clean, minimal design inspired by Linear
 */
const Header = () => {
  const bg = useColorModeValue('white', 'gray.800');
  const borderColor = useColorModeValue('gray.200', 'gray.700');

  return (
    <Box
      bg={bg}
      borderBottom="1px"
      borderColor={borderColor}
      position="fixed"
      top={0}
      left={0}
      right={0}
      zIndex={1000}
      backdropFilter="blur(10px)"
      bgColor="rgba(255, 255, 255, 0.8)"
    >
      <Container maxW="7xl">
        <Flex h={16} alignItems="center" justifyContent="space-between">
          {/* Logo */}
          <Flex alignItems="center">
            <Text
              fontSize="xl"
              fontWeight="bold"
              color="brand.500"
              letterSpacing="tight"
            >
              Fitness Tracker
            </Text>
          </Flex>

          {/* Navigation Links */}
          <HStack spacing={8} display={{ base: 'none', md: 'flex' }}>
            <Link
              href="#features"
              fontSize="sm"
              fontWeight="medium"
              color="gray.700"
              _hover={{ color: 'brand.500' }}
              transition="color 0.2s"
            >
              Features
            </Link>
            <Link
              href="#coaches"
              fontSize="sm"
              fontWeight="medium"
              color="gray.700"
              _hover={{ color: 'brand.500' }}
              transition="color 0.2s"
            >
              Coaches
            </Link>
            <Link
              href="#about"
              fontSize="sm"
              fontWeight="medium"
              color="gray.700"
              _hover={{ color: 'brand.500' }}
              transition="color 0.2s"
            >
              About
            </Link>
          </HStack>

          {/* CTA Buttons */}
          <HStack spacing={4}>
            <Button
              variant="ghost"
              size="sm"
              color="gray.700"
              _hover={{ bg: 'gray.100' }}
            >
              Log in
            </Button>
            <Button
              size="sm"
              colorScheme="brand"
              bg="brand.500"
              _hover={{ bg: 'brand.600' }}
            >
              Get Started
            </Button>
          </HStack>
        </Flex>
      </Container>
    </Box>
  );
};

export default Header;
