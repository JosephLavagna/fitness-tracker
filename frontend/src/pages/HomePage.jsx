import React from 'react';
import {
  Box,
  Container,
  Text,
  Button,
  VStack,
  HStack,
  SimpleGrid,
  Heading,
  Stack,
  Icon,
  Badge,
  useColorModeValue,
  Spinner,
  Alert,
  AlertIcon,
} from '@chakra-ui/react';
import { FiTarget, FiTrendingUp, FiUsers, FiAward } from 'react-icons/fi';
import Header from '../components/Header';
import Footer from '../components/Footer';
import CoachCard from '../components/CoachCard';
import { useFeaturedCoaches } from '../hooks/useCoaches';

/**
 * Home/Landing Page Component
 * Modern design inspired by Linear's clean aesthetic
 * Features hero section, benefits, and featured coaches
 */
const HomePage = () => {
  const { featuredCoaches, loading, error } = useFeaturedCoaches();
  const gradientBg = useColorModeValue(
    'linear(to-br, brand.50, accent.50)',
    'linear(to-br, gray.800, gray.900)'
  );

  return (
    <Box>
      <Header />
      
      {/* Hero Section */}
      <Box
        bgGradient={gradientBg}
        pt={{ base: 24, md: 32 }}
        pb={{ base: 16, md: 20 }}
        minH="80vh"
        display="flex"
        alignItems="center"
      >
        <Container maxW="7xl">
          <Stack
            direction={{ base: 'column', lg: 'row' }}
            spacing={{ base: 8, lg: 16 }}
            align="center"
          >
            {/* Hero Content */}
            <VStack
              align={{ base: 'center', lg: 'start' }}
              spacing={6}
              flex={1}
              textAlign={{ base: 'center', lg: 'left' }}
            >
              <Badge
                colorScheme="brand"
                variant="subtle"
                px={3}
                py={1}
                borderRadius="full"
                fontSize="sm"
              >
                🔥 Transform Your Body Today
              </Badge>
              
              <Heading
                size={{ base: 'xl', md: '2xl', lg: '3xl' }}
                lineHeight="shorter"
                color="gray.800"
                maxW="600px"
              >
                Elite Bodybuilding{' '}
                <Text as="span" color="brand.500">
                  Coaching
                </Text>{' '}
                for Serious Athletes
              </Heading>
              
              <Text
                fontSize={{ base: 'lg', md: 'xl' }}
                color="gray.600"
                maxW="500px"
                lineHeight="tall"
              >
                Work with world-class bodybuilding coaches to build the physique 
                you've always wanted. Personalized training, nutrition, and support 
                to maximize your results.
              </Text>
              
              <HStack spacing={4} pt={4}>
                <Button
                  size="lg"
                  colorScheme="brand"
                  bg="brand.500"
                  _hover={{ bg: 'brand.600', transform: 'translateY(-2px)' }}
                  _active={{ transform: 'translateY(0)' }}
                  transition="all 0.2s"
                  px={8}
                >
                  Start Your Transformation
                </Button>
                <Button
                  size="lg"
                  variant="outline"
                  colorScheme="brand"
                  _hover={{ bg: 'brand.50' }}
                >
                  View Success Stories
                </Button>
              </HStack>
            </VStack>
            
            {/* Hero Visual - Placeholder for now */}
            <Box
              flex={1}
              maxW={{ base: 'full', lg: '500px' }}
              display={{ base: 'none', lg: 'block' }}
            >
              <Box
                h="400px"
                bg="gradient(to-br, brand.400, accent.400)"
                borderRadius="2xl"
                shadow="2xl"
                display="flex"
                alignItems="center"
                justifyContent="center"
                color="white"
                fontSize="xl"
                fontWeight="bold"
              >
                🏋️ Elite Coaching Experience
              </Box>
            </Box>
          </Stack>
        </Container>
      </Box>

      {/* Benefits Section */}
      <Box py={{ base: 16, md: 20 }} id="features">
        <Container maxW="7xl">
          <VStack spacing={12}>
            <VStack spacing={4} textAlign="center">
              <Heading size="lg" color="gray.800">
                Why Choose Fitness Tracker?
              </Heading>
              <Text fontSize="lg" color="gray.600" maxW="600px">
                Our proven system combines expert coaching, personalized programs, 
                and continuous support to deliver exceptional results.
              </Text>
            </VStack>
            
            <SimpleGrid columns={{ base: 1, md: 2, lg: 4 }} spacing={8} w="full">
              {[
                {
                  icon: FiTarget,
                  title: 'Personalized Programs',
                  description: 'Custom training and nutrition plans tailored to your goals and body type.',
                },
                {
                  icon: FiTrendingUp,
                  title: 'Proven Results',
                  description: 'Track record of transforming hundreds of athletes and competitors.',
                },
                {
                  icon: FiUsers,
                  title: 'Expert Coaches',
                  description: 'Work with certified professionals with years of competitive experience.',
                },
                {
                  icon: FiAward,
                  title: 'Competition Prep',
                  description: 'Specialized programs for bodybuilding competitions and contests.',
                },
              ].map((benefit, index) => (
                <VStack
                  key={index}
                  p={6}
                  bg="white"
                  borderRadius="xl"
                  border="1px"
                  borderColor="gray.200"
                  spacing={4}
                  align="start"
                  transition="all 0.3s"
                  _hover={{
                    transform: 'translateY(-4px)',
                    shadow: 'lg',
                    borderColor: 'brand.300',
                  }}
                >
                  <Icon as={benefit.icon} boxSize={8} color="brand.500" />
                  <VStack align="start" spacing={2}>
                    <Text fontWeight="bold" fontSize="lg" color="gray.800">
                      {benefit.title}
                    </Text>
                    <Text color="gray.600" lineHeight="tall">
                      {benefit.description}
                    </Text>
                  </VStack>
                </VStack>
              ))}
            </SimpleGrid>
          </VStack>
        </Container>
      </Box>

      {/* Featured Coaches Section */}
      <Box py={{ base: 16, md: 20 }} bg="gray.50" id="coaches">
        <Container maxW="7xl">
          <VStack spacing={12}>
            <VStack spacing={4} textAlign="center">
              <Heading size="lg" color="gray.800">
                Meet Our Elite Coaches
              </Heading>
              <Text fontSize="lg" color="gray.600" maxW="600px">
                Work with the best in the industry. Our coaches have competed at the 
                highest levels and helped countless athletes achieve their dreams.
              </Text>
            </VStack>
            
            {/* Loading and Error States */}
            {loading && (
              <VStack spacing={4}>
                <Spinner size="xl" color="brand.500" />
                <Text color="gray.600">Loading our amazing coaches...</Text>
              </VStack>
            )}
            
            {error && (
              <Alert status="error" borderRadius="lg" maxW="500px">
                <AlertIcon />
                {error}
              </Alert>
            )}
            
            {/* Coaches Grid */}
            {!loading && !error && (
              <SimpleGrid
                columns={{ base: 1, md: 2, lg: 3 }}
                spacing={8}
                w="full"
              >
                {featuredCoaches.map((coach) => (
                  <CoachCard key={coach.id} coach={coach} />
                ))}
              </SimpleGrid>
            )}
          </VStack>
        </Container>
      </Box>

      {/* CTA Section */}
      <Box py={{ base: 16, md: 20 }}>
        <Container maxW="4xl">
          <VStack
            spacing={8}
            p={{ base: 8, md: 12 }}
            bg="white"
            borderRadius="2xl"
            border="1px"
            borderColor="gray.200"
            shadow="xl"
            textAlign="center"
          >
            <VStack spacing={4}>
              <Heading size="lg" color="gray.800">
                Ready to Transform Your Physique?
              </Heading>
              <Text fontSize="lg" color="gray.600" maxW="500px">
                Join hundreds of successful athletes who have achieved their 
                bodybuilding goals with our expert coaching.
              </Text>
            </VStack>
            
            <HStack spacing={4}>
              <Button
                size="lg"
                colorScheme="brand"
                bg="brand.500"
                _hover={{ bg: 'brand.600' }}
                px={8}
              >
                Get Started Today
              </Button>
              <Button
                size="lg"
                variant="outline"
                colorScheme="brand"
              >
                Schedule a Consultation
              </Button>
            </HStack>
            
            <Text fontSize="sm" color="gray.500">
              No commitment required • Free initial consultation
            </Text>
          </VStack>
        </Container>
      </Box>

      <Footer />
    </Box>
  );
};

export default HomePage;
